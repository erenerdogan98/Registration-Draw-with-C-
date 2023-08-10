namespace Promotion.UI.WinForm
{
    partial class MainForm
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
            this.grpbox_customerinformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tckimlikno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime_birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emailaddrres = new System.Windows.Forms.TextBox();
            this.checkbox_email = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.checkbox_phone = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.flowpanel_gift = new System.Windows.Forms.FlowLayoutPanel();
            this.grpbox_customerinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_customerinformation
            // 
            this.grpbox_customerinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpbox_customerinformation.Controls.Add(this.btn_cancel);
            this.grpbox_customerinformation.Controls.Add(this.btn_Save);
            this.grpbox_customerinformation.Controls.Add(this.checkbox_phone);
            this.grpbox_customerinformation.Controls.Add(this.checkbox_email);
            this.grpbox_customerinformation.Controls.Add(this.cmb_gender);
            this.grpbox_customerinformation.Controls.Add(this.txt_phonenumber);
            this.grpbox_customerinformation.Controls.Add(this.datetime_birth);
            this.grpbox_customerinformation.Controls.Add(this.txt_emailaddrres);
            this.grpbox_customerinformation.Controls.Add(this.txt_job);
            this.grpbox_customerinformation.Controls.Add(this.txt_tckimlikno);
            this.grpbox_customerinformation.Controls.Add(this.label8);
            this.grpbox_customerinformation.Controls.Add(this.label4);
            this.grpbox_customerinformation.Controls.Add(this.label7);
            this.grpbox_customerinformation.Controls.Add(this.label5);
            this.grpbox_customerinformation.Controls.Add(this.label6);
            this.grpbox_customerinformation.Controls.Add(this.txt_surname);
            this.grpbox_customerinformation.Controls.Add(this.label3);
            this.grpbox_customerinformation.Controls.Add(this.txt_name);
            this.grpbox_customerinformation.Controls.Add(this.label2);
            this.grpbox_customerinformation.Controls.Add(this.label1);
            this.grpbox_customerinformation.Location = new System.Drawing.Point(497, 4);
            this.grpbox_customerinformation.Name = "grpbox_customerinformation";
            this.grpbox_customerinformation.Size = new System.Drawing.Size(314, 447);
            this.grpbox_customerinformation.TabIndex = 0;
            this.grpbox_customerinformation.TabStop = false;
            this.grpbox_customerinformation.Text = "Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(107, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(201, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(107, 74);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(201, 20);
            this.txt_surname.TabIndex = 1;
            this.txt_surname.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_surname.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCKimlik No";
            // 
            // txt_tckimlikno
            // 
            this.txt_tckimlikno.Location = new System.Drawing.Point(107, 100);
            this.txt_tckimlikno.Name = "txt_tckimlikno";
            this.txt_tckimlikno.Size = new System.Drawing.Size(201, 20);
            this.txt_tckimlikno.TabIndex = 2;
            this.txt_tckimlikno.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_tckimlikno.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birth Date";
            // 
            // datetime_birth
            // 
            this.datetime_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_birth.Location = new System.Drawing.Point(107, 126);
            this.datetime_birth.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.datetime_birth.MinDate = new System.DateTime(1978, 1, 1, 0, 0, 0, 0);
            this.datetime_birth.Name = "datetime_birth";
            this.datetime_birth.Size = new System.Drawing.Size(201, 20);
            this.datetime_birth.TabIndex = 3;
            this.datetime_birth.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.datetime_birth.Enter += new System.EventHandler(this.datetime_birth_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(107, 152);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(201, 21);
            this.cmb_gender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Job";
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(107, 179);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(201, 20);
            this.txt_job.TabIndex = 5;
            this.txt_job.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_job.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email Address";
            // 
            // txt_emailaddrres
            // 
            this.txt_emailaddrres.Location = new System.Drawing.Point(107, 205);
            this.txt_emailaddrres.Name = "txt_emailaddrres";
            this.txt_emailaddrres.Size = new System.Drawing.Size(201, 20);
            this.txt_emailaddrres.TabIndex = 6;
            this.txt_emailaddrres.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_emailaddrres.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // checkbox_email
            // 
            this.checkbox_email.AutoSize = true;
            this.checkbox_email.Location = new System.Drawing.Point(107, 231);
            this.checkbox_email.Name = "checkbox_email";
            this.checkbox_email.Size = new System.Drawing.Size(192, 17);
            this.checkbox_email.TabIndex = 7;
            this.checkbox_email.Text = "I want to receive e-mail notification.";
            this.checkbox_email.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phone Number";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(107, 252);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(201, 20);
            this.txt_phonenumber.TabIndex = 8;
            this.txt_phonenumber.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_phonenumber.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // checkbox_phone
            // 
            this.checkbox_phone.AutoSize = true;
            this.checkbox_phone.Location = new System.Drawing.Point(107, 278);
            this.checkbox_phone.Name = "checkbox_phone";
            this.checkbox_phone.Size = new System.Drawing.Size(188, 17);
            this.checkbox_phone.TabIndex = 9;
            this.checkbox_phone.Text = "I want to receive SMS notification.";
            this.checkbox_phone.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(107, 314);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(201, 32);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cancel.Location = new System.Drawing.Point(107, 352);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(201, 32);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // flowpanel_gift
            // 
            this.flowpanel_gift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowpanel_gift.Location = new System.Drawing.Point(4, 4);
            this.flowpanel_gift.Name = "flowpanel_gift";
            this.flowpanel_gift.Size = new System.Drawing.Size(487, 447);
            this.flowpanel_gift.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.flowpanel_gift);
            this.Controls.Add(this.grpbox_customerinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpbox_customerinformation.ResumeLayout(false);
            this.grpbox_customerinformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_customerinformation;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.CheckBox checkbox_phone;
        private System.Windows.Forms.CheckBox checkbox_email;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.DateTimePicker datetime_birth;
        private System.Windows.Forms.TextBox txt_emailaddrres;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.TextBox txt_tckimlikno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowpanel_gift;
    }
}