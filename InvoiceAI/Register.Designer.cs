
namespace InvoiceAI
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            this.gbOrganizationDetail = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSystemProvider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDBMS = new System.Windows.Forms.ComboBox();
            this.tbOrgContactEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrgContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrgRegNo = new System.Windows.Forms.TextBox();
            this.lblOrgRegNo = new System.Windows.Forms.Label();
            this.tbOrgAddress = new System.Windows.Forms.TextBox();
            this.lblOrgAddress = new System.Windows.Forms.Label();
            this.tbOrgName = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbUserReg = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbxShowPas = new System.Windows.Forms.CheckBox();
            this.txtComPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbOrganizationDetail.SuspendLayout();
            this.gbUserReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOrganizationDetail
            // 
            this.gbOrganizationDetail.Controls.Add(this.label4);
            this.gbOrganizationDetail.Controls.Add(this.cbSystemProvider);
            this.gbOrganizationDetail.Controls.Add(this.label3);
            this.gbOrganizationDetail.Controls.Add(this.cbDBMS);
            this.gbOrganizationDetail.Controls.Add(this.tbOrgContactEmail);
            this.gbOrganizationDetail.Controls.Add(this.label2);
            this.gbOrganizationDetail.Controls.Add(this.tbOrgContact);
            this.gbOrganizationDetail.Controls.Add(this.label1);
            this.gbOrganizationDetail.Controls.Add(this.tbOrgRegNo);
            this.gbOrganizationDetail.Controls.Add(this.lblOrgRegNo);
            this.gbOrganizationDetail.Controls.Add(this.tbOrgAddress);
            this.gbOrganizationDetail.Controls.Add(this.lblOrgAddress);
            this.gbOrganizationDetail.Controls.Add(this.tbOrgName);
            this.gbOrganizationDetail.Controls.Add(this.lblOrgName);
            this.gbOrganizationDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.gbOrganizationDetail.Location = new System.Drawing.Point(55, 175);
            this.gbOrganizationDetail.Name = "gbOrganizationDetail";
            this.gbOrganizationDetail.Size = new System.Drawing.Size(674, 464);
            this.gbOrganizationDetail.TabIndex = 2;
            this.gbOrganizationDetail.TabStop = false;
            this.gbOrganizationDetail.Text = "Organization Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Who is your current system Provider?";
            // 
            // cbSystemProvider
            // 
            this.cbSystemProvider.BackColor = System.Drawing.Color.White;
            this.cbSystemProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSystemProvider.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cbSystemProvider.FormattingEnabled = true;
            this.cbSystemProvider.Items.AddRange(new object[] {
            "MyPOS",
            "Future Vision IT",
            "IPOS",
            "Others"});
            this.cbSystemProvider.Location = new System.Drawing.Point(379, 137);
            this.cbSystemProvider.Name = "cbSystemProvider";
            this.cbSystemProvider.Size = new System.Drawing.Size(267, 31);
            this.cbSystemProvider.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Which Database curently using?";
            // 
            // cbDBMS
            // 
            this.cbDBMS.BackColor = System.Drawing.Color.White;
            this.cbDBMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDBMS.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cbDBMS.FormattingEnabled = true;
            this.cbDBMS.Items.AddRange(new object[] {
            "Microsoft SQL Server 2012",
            "Microsoft SQL Server 2014",
            "MySQL",
            "Oracle Database",
            "PostgreSQL"});
            this.cbDBMS.Location = new System.Drawing.Point(379, 71);
            this.cbDBMS.Name = "cbDBMS";
            this.cbDBMS.Size = new System.Drawing.Size(267, 31);
            this.cbDBMS.TabIndex = 6;
            // 
            // tbOrgContactEmail
            // 
            this.tbOrgContactEmail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgContactEmail.Location = new System.Drawing.Point(22, 413);
            this.tbOrgContactEmail.Name = "tbOrgContactEmail";
            this.tbOrgContactEmail.Size = new System.Drawing.Size(306, 27);
            this.tbOrgContactEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Organziation Contact Email";
            // 
            // tbOrgContact
            // 
            this.tbOrgContact.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgContact.Location = new System.Drawing.Point(22, 341);
            this.tbOrgContact.Name = "tbOrgContact";
            this.tbOrgContact.Size = new System.Drawing.Size(306, 27);
            this.tbOrgContact.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Organziation Contact Number";
            // 
            // tbOrgRegNo
            // 
            this.tbOrgRegNo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgRegNo.Location = new System.Drawing.Point(22, 137);
            this.tbOrgRegNo.Name = "tbOrgRegNo";
            this.tbOrgRegNo.Size = new System.Drawing.Size(306, 27);
            this.tbOrgRegNo.TabIndex = 2;
            // 
            // lblOrgRegNo
            // 
            this.lblOrgRegNo.AutoSize = true;
            this.lblOrgRegNo.Location = new System.Drawing.Point(22, 111);
            this.lblOrgRegNo.Name = "lblOrgRegNo";
            this.lblOrgRegNo.Size = new System.Drawing.Size(215, 23);
            this.lblOrgRegNo.TabIndex = 6;
            this.lblOrgRegNo.Text = "Organziation Register Number";
            // 
            // tbOrgAddress
            // 
            this.tbOrgAddress.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.tbOrgAddress.Location = new System.Drawing.Point(22, 213);
            this.tbOrgAddress.Multiline = true;
            this.tbOrgAddress.Name = "tbOrgAddress";
            this.tbOrgAddress.Size = new System.Drawing.Size(306, 80);
            this.tbOrgAddress.TabIndex = 3;
            // 
            // lblOrgAddress
            // 
            this.lblOrgAddress.AutoSize = true;
            this.lblOrgAddress.Location = new System.Drawing.Point(22, 187);
            this.lblOrgAddress.Name = "lblOrgAddress";
            this.lblOrgAddress.Size = new System.Drawing.Size(157, 23);
            this.lblOrgAddress.TabIndex = 4;
            this.lblOrgAddress.Text = "Organziation Address";
            // 
            // tbOrgName
            // 
            this.tbOrgName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrgName.Location = new System.Drawing.Point(22, 71);
            this.tbOrgName.Name = "tbOrgName";
            this.tbOrgName.Size = new System.Drawing.Size(306, 27);
            this.tbOrgName.TabIndex = 1;
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Location = new System.Drawing.Point(22, 45);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(142, 23);
            this.lblOrgName.TabIndex = 2;
            this.lblOrgName.Text = "Organziation Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(483, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Organization Registration";
            // 
            // gbUserReg
            // 
            this.gbUserReg.Controls.Add(this.label14);
            this.gbUserReg.Controls.Add(this.label13);
            this.gbUserReg.Controls.Add(this.label8);
            this.gbUserReg.Controls.Add(this.label7);
            this.gbUserReg.Controls.Add(this.label6);
            this.gbUserReg.Controls.Add(this.label9);
            this.gbUserReg.Controls.Add(this.button2);
            this.gbUserReg.Controls.Add(this.button1);
            this.gbUserReg.Controls.Add(this.checkbxShowPas);
            this.gbUserReg.Controls.Add(this.txtComPassword);
            this.gbUserReg.Controls.Add(this.label10);
            this.gbUserReg.Controls.Add(this.txtPassword);
            this.gbUserReg.Controls.Add(this.label11);
            this.gbUserReg.Controls.Add(this.txtUsername);
            this.gbUserReg.Controls.Add(this.lblUsername);
            this.gbUserReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.gbUserReg.Location = new System.Drawing.Point(755, 175);
            this.gbUserReg.Name = "gbUserReg";
            this.gbUserReg.Size = new System.Drawing.Size(420, 464);
            this.gbUserReg.TabIndex = 9;
            this.gbUserReg.TabStop = false;
            this.gbUserReg.Text = "User Registration";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(101, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 22);
            this.label14.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(210, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 21);
            this.label13.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(208, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Version 1.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(165, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Back to LOGIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Already Have an Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbxShowPas
            // 
            this.checkbxShowPas.AutoSize = true;
            this.checkbxShowPas.BackColor = System.Drawing.Color.Transparent;
            this.checkbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPas.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxShowPas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkbxShowPas.Location = new System.Drawing.Point(197, 231);
            this.checkbxShowPas.Name = "checkbxShowPas";
            this.checkbxShowPas.Size = new System.Drawing.Size(124, 23);
            this.checkbxShowPas.TabIndex = 11;
            this.checkbxShowPas.Text = "Show Password";
            this.checkbxShowPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbxShowPas.UseVisualStyleBackColor = false;
            this.checkbxShowPas.CheckedChanged += new System.EventHandler(this.checkbxShowPas_CheckedChanged);
            // 
            // txtComPassword
            // 
            this.txtComPassword.BackColor = System.Drawing.Color.White;
            this.txtComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComPassword.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtComPassword.Location = new System.Drawing.Point(102, 192);
            this.txtComPassword.Multiline = true;
            this.txtComPassword.Name = "txtComPassword";
            this.txtComPassword.PasswordChar = '*';
            this.txtComPassword.Size = new System.Drawing.Size(216, 27);
            this.txtComPassword.TabIndex = 10;
            this.txtComPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComPassword_KeyDown);
            this.txtComPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtComPassword_Validating);
            this.txtComPassword.Validated += new System.EventHandler(this.txtComPassword_Validated);
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(96, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(102, 126);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 27);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(96, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 59;
            this.label11.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtUsername.Location = new System.Drawing.Point(102, 65);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 27);
            this.txtUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(96, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 23);
            this.lblUsername.TabIndex = 56;
            this.lblUsername.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(1183, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Close";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvoiceAI.Properties.Resources.InvoiceAI;
            this.pictureBox1.Location = new System.Drawing.Point(55, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 711);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbUserReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbOrganizationDetail);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.gbOrganizationDetail.ResumeLayout(false);
            this.gbOrganizationDetail.PerformLayout();
            this.gbUserReg.ResumeLayout(false);
            this.gbUserReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrganizationDetail;
        private System.Windows.Forms.TextBox tbOrgName;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.TextBox tbOrgAddress;
        private System.Windows.Forms.Label lblOrgAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSystemProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDBMS;
        private System.Windows.Forms.TextBox tbOrgContactEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrgContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrgRegNo;
        private System.Windows.Forms.Label lblOrgRegNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUserReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbxShowPas;
        private System.Windows.Forms.TextBox txtComPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}