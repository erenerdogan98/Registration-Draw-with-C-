using Entities;
using Promotion.BLL;
using Promotion.Core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promotion.UI.WinForm
{
    public partial class MainForm : Form
    {
        PotentialCustomer data; // we sample this in class level and we will use 
        public MainForm()
        {
            InitializeComponent();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Pink;
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void datetime_birth_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            GroupBox customerinformation = (GroupBox)this.Controls["grpbox_customerinformation"];
            foreach (Control item in customerinformation.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region  values for textbox names
            string tckimlikno = txt_tckimlikno.Text;
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            DateTime birthdate = datetime_birth.Value;
            int gender = ((Gender)cmb_gender.SelectedItem).ID;
            string job = txt_job.Text;
            string emailaddress = txt_emailaddrres.Text;
            string phonenumber = txt_phonenumber.Text;
            bool emailconfirmation = checkbox_email.Checked;
            bool phoneconfirmation = checkbox_phone.Checked;
            DateTime creationdate = DateTime.Now;
            int creatorstore = StaticFields.StoreID;
            #endregion
            PotentialCustomerService customerService = new PotentialCustomerService();
            int tccontrol = customerService.InquireTC(tckimlikno);
            if (tccontrol > 0) // InquireTC method contacts with ID so it return ID > count
            {
                MessageBox.Show("There is a registered user with this ID (TC Kimlik) number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                data = new PotentialCustomer();
                data.TCKimlikNo = tckimlikno;
                data.Name = name;
                data.Surname = surname;
                data.BirthDay = birthdate;
                data.Gender = gender;
                data.Job = job;
                data.EmailAddress = emailaddress;
                data.EmailConfirmation = emailconfirmation;
                data.PhoneNumber = phonenumber;
                data.PhoneConfirmation = phoneconfirmation;
                data.CreationDate = creationdate; // should write min value because of SQL error.
                data.CreatorStore = creatorstore;

                int CustomerRegist = customerService.NewRegistration(data);
                if(CustomerRegist > 0)
                {
                    MessageBox.Show("Your registration is successful. You can choose the gift.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    PrepareGiftSelection();
                }
                else
                {
                    MessageBox.Show("System Error!!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #region Preparing gift selection
        private void PrepareGiftSelection() // we call this method to successfull registration 
        {
            List<PromotionProduct> GiftProdutcs = new List<PromotionProduct>();
            PromotionProductService promotionProductService = new PromotionProductService();
            GiftProdutcs = promotionProductService.GetProductList();
            if(GiftProdutcs != null && GiftProdutcs.Count>0)
            {
                for (int i = 0; i < GiftProdutcs.Count; i++)
                {
                    // System.Threading.Thread.Sleep(2000);
                    PictureBox pictureBox = new PictureBox(); 
                    pictureBox.Width = 62;
                    pictureBox.Height = 65;

                    pictureBox.Image = Image.FromFile(@"D:\Downloads\Gift.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = GiftProdutcs[i]; // we keep a gift 
                    pictureBox.Click += pictureBox_Click;
                    flowpanel_gift.Controls.Add(pictureBox);
                }
            }
            else
            {
                MessageBox.Show("The campaign has expired.", "Information about campaign", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // we convert what comes from sender into a picture box
            PictureBox choosengift = (PictureBox)sender; 
            PromotionProduct productwon = (PromotionProduct)choosengift.Tag;
           
            if(productwon != null && productwon.ID > 0)
            {
                ParticipantPromotionService participantservice = new ParticipantPromotionService();
                PromotionProductService productService = new PromotionProductService();
                PotentialCustomerService potentialCustomer = new PotentialCustomerService();

                productService.Marktheproductused(productwon.ID);
                participantservice.NewReg(new ParticipantPromotion()
                {
                    StoreID = StaticFields.StoreID,
                    CreationDate = DateTime.Now,
                    PromotionProductID = productwon.ID,
                    PotentialCustomerID = potentialCustomer.InquireTC(txt_tckimlikno.Text),
                });
                // now we will Show gift 
                #region for showing gift
                ShowGift showinggiftform = new ShowGift(productwon);
                showinggiftform.ShowDialog(); 
                #endregion
            }
            else
            {
                MessageBox.Show("The campaign has expired.", "Information about campaign", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // normally , if there is any error occurs , it is the system error , next versions i will upgrade somethings about project.
            }
            

        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            // we write gender codes onload 
            #region for gender codes
            cmb_gender.DataSource = StaticFields.Genders();
            #endregion
        }
      
    }
}
