using Entities;
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
    public partial class ShowGift : Form
    {
        public ShowGift(PromotionProduct data) // we take this to show data
        {
            InitializeComponent();

            lbl_giftdesc.Text = $"Congratulations, you have won  {data.Definition} {data.Explanation} ";
        }

        private void ShowGift_Load(object sender, EventArgs e)
        {

        }

        private void btn_newreglog_Click(object sender, EventArgs e)
        {
            //  We find the form in ram and then we close it.
            Form Main_form = Application.OpenForms["MainForm"];
            Main_form.Close();

            // after that , we will show MainForm by new
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Close(); // we close showgift form 
        }
    }
}
