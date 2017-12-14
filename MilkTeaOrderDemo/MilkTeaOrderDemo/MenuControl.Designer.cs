namespace MilkTeaOrderDemo
{
    partial class MenuControl
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.orderSide2 = new MilkTeaOrderDemo.OrderSide();
            this.orderSide1 = new MilkTeaOrderDemo.OrderSide();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panMenu.BackColor = System.Drawing.Color.White;
            this.panMenu.Controls.Add(this.panel1);
            this.panMenu.Location = new System.Drawing.Point(0, 22);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(718, 644);
            this.panMenu.TabIndex = 1;
            // 
            // orderSide2
            // 
            this.orderSide2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderSide2.Location = new System.Drawing.Point(718, 22);
            this.orderSide2.Name = "orderSide2";
            this.orderSide2.Size = new System.Drawing.Size(312, 644);
            this.orderSide2.TabIndex = 2;
            // 
            // orderSide1
            // 
            this.orderSide1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderSide1.Location = new System.Drawing.Point(720, 22);
            this.orderSide1.Name = "orderSide1";
            this.orderSide1.Size = new System.Drawing.Size(310, 644);
            this.orderSide1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(701, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 644);
            this.panel1.TabIndex = 0;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderSide2);
            this.Controls.Add(this.panMenu);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(1030, 667);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private OrderSide orderSide1;
        private OrderSide orderSide2;
        private System.Windows.Forms.Panel panel1;
    }
}
