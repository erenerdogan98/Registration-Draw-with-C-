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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // for much clear code , i will write like that
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                SystemStoreService storeService = new SystemStoreService();
                int StoreID = storeService.StoreUserControl(username, password);
                if (StoreID > 0)
                {
                    StaticFields.StoreID = StoreID;
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // We save this form.
                }
                else
                    MessageBox.Show("Incorrect username or password entry", "Logın Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Fill in the form fields completely!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
