
namespace InvoiceAI
{
    partial class ocrloading
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
            this.lblPlease = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlease.Location = new System.Drawing.Point(79, 22);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(111, 25);
            this.lblPlease.TabIndex = 9;
            this.lblPlease.Text = "Please Wait....";
            // 
            // pbLoad
            // 
            this.pbLoad.Image = global::InvoiceAI.Properties.Resources.Search;
            this.pbLoad.Location = new System.Drawing.Point(11, 10);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(48, 48);
            this.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoad.TabIndex = 10;
            this.pbLoad.TabStop = false;
            // 
            // ocrloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(207, 69);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.lblPlease);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ocrloading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ocrloading";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlease;
        private System.Windows.Forms.PictureBox pbLoad;
    }
}