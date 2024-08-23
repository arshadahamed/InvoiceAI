
namespace InvoiceAI
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettingDash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDashUesr = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDashUserType = new System.Windows.Forms.Label();
            this.btnInventoryDash = new System.Windows.Forms.Button();
            this.btnInvDash = new System.Windows.Forms.Button();
            this.btnOCR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnSettingDash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnInventoryDash);
            this.panel1.Controls.Add(this.btnInvDash);
            this.panel1.Controls.Add(this.btnOCR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1080);
            this.panel1.TabIndex = 1;
            // 
            // btnSettingDash
            // 
            this.btnSettingDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnSettingDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingDash.FlatAppearance.BorderSize = 0;
            this.btnSettingDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSettingDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSettingDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingDash.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingDash.ForeColor = System.Drawing.Color.White;
            this.btnSettingDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingDash.Location = new System.Drawing.Point(0, 341);
            this.btnSettingDash.Name = "btnSettingDash";
            this.btnSettingDash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettingDash.Size = new System.Drawing.Size(220, 47);
            this.btnSettingDash.TabIndex = 14;
            this.btnSettingDash.Text = "          Setting";
            this.btnSettingDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingDash.UseVisualStyleBackColor = false;
            this.btnSettingDash.Click += new System.EventHandler(this.btnSettingDash_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDashUesr);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblDashUserType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 946);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 134);
            this.panel3.TabIndex = 15;
            // 
            // lblDashUesr
            // 
            this.lblDashUesr.AutoSize = true;
            this.lblDashUesr.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashUesr.ForeColor = System.Drawing.Color.White;
            this.lblDashUesr.Location = new System.Drawing.Point(65, 45);
            this.lblDashUesr.Name = "lblDashUesr";
            this.lblDashUesr.Size = new System.Drawing.Size(47, 23);
            this.lblDashUesr.TabIndex = 4;
            this.lblDashUesr.Text = "User ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InvoiceAI.Properties.Resources.icons8_Logout_50px;
            this.pictureBox3.Location = new System.Drawing.Point(163, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InvoiceAI.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(10, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblDashUserType
            // 
            this.lblDashUserType.AutoSize = true;
            this.lblDashUserType.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashUserType.ForeColor = System.Drawing.Color.White;
            this.lblDashUserType.Location = new System.Drawing.Point(66, 74);
            this.lblDashUserType.Name = "lblDashUserType";
            this.lblDashUserType.Size = new System.Drawing.Size(58, 23);
            this.lblDashUserType.TabIndex = 1;
            this.lblDashUserType.Text = "Admin";
            // 
            // btnInventoryDash
            // 
            this.btnInventoryDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnInventoryDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryDash.FlatAppearance.BorderSize = 0;
            this.btnInventoryDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnInventoryDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnInventoryDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryDash.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDash.ForeColor = System.Drawing.Color.White;
            this.btnInventoryDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryDash.Location = new System.Drawing.Point(0, 294);
            this.btnInventoryDash.Name = "btnInventoryDash";
            this.btnInventoryDash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventoryDash.Size = new System.Drawing.Size(220, 47);
            this.btnInventoryDash.TabIndex = 12;
            this.btnInventoryDash.Text = "          Organization";
            this.btnInventoryDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryDash.UseVisualStyleBackColor = false;
            this.btnInventoryDash.Click += new System.EventHandler(this.btnInventoryDash_Click);
            // 
            // btnInvDash
            // 
            this.btnInvDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnInvDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvDash.FlatAppearance.BorderSize = 0;
            this.btnInvDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnInvDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnInvDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvDash.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvDash.ForeColor = System.Drawing.Color.White;
            this.btnInvDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvDash.Location = new System.Drawing.Point(0, 247);
            this.btnInvDash.Name = "btnInvDash";
            this.btnInvDash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInvDash.Size = new System.Drawing.Size(220, 47);
            this.btnInvDash.TabIndex = 10;
            this.btnInvDash.Text = "          Invoice List";
            this.btnInvDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvDash.UseVisualStyleBackColor = false;
            this.btnInvDash.Click += new System.EventHandler(this.btnInvDash_Click);
            // 
            // btnOCR
            // 
            this.btnOCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.btnOCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOCR.FlatAppearance.BorderSize = 0;
            this.btnOCR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnOCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOCR.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOCR.ForeColor = System.Drawing.Color.White;
            this.btnOCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOCR.Location = new System.Drawing.Point(0, 200);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOCR.Size = new System.Drawing.Size(220, 47);
            this.btnOCR.TabIndex = 8;
            this.btnOCR.Text = "          OCR";
            this.btnOCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOCR.UseVisualStyleBackColor = false;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 200);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(99)))));
            this.button1.Location = new System.Drawing.Point(23, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(64, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "InvoiceAI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvoiceAI.Properties.Resources.InvoiceAI;
            this.pictureBox1.Location = new System.Drawing.Point(52, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 48);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1700, 1032);
            this.panelContent.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1633, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Close";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1700, 48);
            this.panel4.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettingDash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDashUserType;
        private System.Windows.Forms.Button btnInventoryDash;
        private System.Windows.Forms.Button btnInvDash;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblDashUesr;
    }
}