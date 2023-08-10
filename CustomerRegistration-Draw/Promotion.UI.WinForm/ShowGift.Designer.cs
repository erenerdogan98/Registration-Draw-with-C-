namespace Promotion.UI.WinForm
{
    partial class ShowGift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowGift));
            this.btn_newreglog = new System.Windows.Forms.Button();
            this.pct_giftpic = new System.Windows.Forms.PictureBox();
            this.lbl_giftdesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_giftpic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newreglog
            // 
            this.btn_newreglog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_newreglog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newreglog.Location = new System.Drawing.Point(29, 191);
            this.btn_newreglog.Name = "btn_newreglog";
            this.btn_newreglog.Size = new System.Drawing.Size(524, 43);
            this.btn_newreglog.TabIndex = 0;
            this.btn_newreglog.Text = "NEW REGISTRATION LOGIN";
            this.btn_newreglog.UseVisualStyleBackColor = false;
            this.btn_newreglog.Click += new System.EventHandler(this.btn_newreglog_Click);
            // 
            // pct_giftpic
            // 
            this.pct_giftpic.Image = ((System.Drawing.Image)(resources.GetObject("pct_giftpic.Image")));
            this.pct_giftpic.Location = new System.Drawing.Point(29, 12);
            this.pct_giftpic.Name = "pct_giftpic";
            this.pct_giftpic.Size = new System.Drawing.Size(171, 173);
            this.pct_giftpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_giftpic.TabIndex = 1;
            this.pct_giftpic.TabStop = false;
            // 
            // lbl_giftdesc
            // 
            this.lbl_giftdesc.AutoSize = true;
            this.lbl_giftdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giftdesc.Location = new System.Drawing.Point(236, 84);
            this.lbl_giftdesc.Name = "lbl_giftdesc";
            this.lbl_giftdesc.Size = new System.Drawing.Size(13, 20);
            this.lbl_giftdesc.TabIndex = 2;
            this.lbl_giftdesc.Text = ".";
            // 
            // ShowGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 235);
            this.Controls.Add(this.lbl_giftdesc);
            this.Controls.Add(this.pct_giftpic);
            this.Controls.Add(this.btn_newreglog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowGift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowGift";
            this.Load += new System.EventHandler(this.ShowGift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_giftpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newreglog;
        private System.Windows.Forms.PictureBox pct_giftpic;
        private System.Windows.Forms.Label lbl_giftdesc;
    }
}