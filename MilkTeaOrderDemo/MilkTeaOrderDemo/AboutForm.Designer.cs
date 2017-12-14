namespace MilkTeaOrderDemo
{
    partial class AboutForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(206, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 224);
            this.label1.TabIndex = 0;
            this.label1.Text = "This application belongs to us:\r\nPham Ngoc Minh Thanh\r\nTran Thi My Dieu\r\nNguyen T" +
    "hi Ngoc Anh\r\nHa Phuoc Tai\r\n\r\nContact us via Facebook for more information!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFacebook
            // 
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(347, 439);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(61, 59);
            this.btnFacebook.TabIndex = 1;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            this.btnIns.FlatAppearance.BorderSize = 0;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Image = ((System.Drawing.Image)(resources.GetObject("btnIns.Image")));
            this.btnIns.Location = new System.Drawing.Point(476, 439);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(61, 59);
            this.btnIns.TabIndex = 1;
            this.btnIns.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.Location = new System.Drawing.Point(605, 439);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(61, 59);
            this.btnEmail.TabIndex = 1;
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.label1);
            this.Name = "AboutForm";
            this.Size = new System.Drawing.Size(1030, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnEmail;
    }
}
