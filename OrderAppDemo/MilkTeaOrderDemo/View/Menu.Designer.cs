namespace MilkTeaOrderDemo
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.picFood);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 200);
            this.panel1.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(64, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 21);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "lbPrice";
            // 
            // lblName
            // 
            this.lblName.AllowDrop = true;
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 138);
            this.lblName.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lbName\r\n";
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(11, 3);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(128, 128);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            this.picFood.Click += new System.EventHandler(this.picFood_Click);
            this.picFood.MouseEnter += new System.EventHandler(this.picFood_MouseEnter);
            this.picFood.MouseLeave += new System.EventHandler(this.picFood_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(150, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picFood;
    }
}
