namespace MilkTeaOrderDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnESC = new System.Windows.Forms.Button();
            this.homeControl1 = new MilkTeaOrderDemo.HomeUserControl();
            this.aboutForm1 = new MilkTeaOrderDemo.AboutForm();
            this.editFoodForm1 = new MilkTeaOrderDemo.EditFoodForm();
            this.menuForm1 = new MilkTeaOrderDemo.MenuForm();
            this.homeUserControl1 = new MilkTeaOrderDemo.HomeUserControl();
            this.LeftSidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.Gray;
            this.LeftSidePanel.Controls.Add(this.LogoPanel);
            this.LeftSidePanel.Controls.Add(this.SidePanel);
            this.LeftSidePanel.Controls.Add(this.btnAbout);
            this.LeftSidePanel.Controls.Add(this.btnOption);
            this.LeftSidePanel.Controls.Add(this.btnMenu);
            this.LeftSidePanel.Controls.Add(this.btnHome);
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 5);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(250, 720);
            this.LeftSidePanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.LogoPanel.Controls.Add(this.label2);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Controls.Add(this.pictureBox6);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 111);
            this.LogoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(132, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUISINE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "KOREAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(97, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 151);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 88);
            this.SidePanel.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(12, 442);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(238, 88);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "ABOUT  ";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // btnOption
            // 
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOption.Image = ((System.Drawing.Image)(resources.GetObject("btnOption.Image")));
            this.btnOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.Location = new System.Drawing.Point(12, 348);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(238, 88);
            this.btnOption.TabIndex = 2;
            this.btnOption.Text = "OPTION";
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(12, 254);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(238, 88);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "MENU  ";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 151);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(238, 88);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME  ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnESC);
            this.TopPanel.Location = new System.Drawing.Point(250, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1032, 51);
            this.TopPanel.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(908, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnESC
            // 
            this.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnESC.FlatAppearance.BorderSize = 0;
            this.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnESC.Image = ((System.Drawing.Image)(resources.GetObject("btnESC.Image")));
            this.btnESC.Location = new System.Drawing.Point(972, 7);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(35, 35);
            this.btnESC.TabIndex = 2;
            this.btnESC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnESC.UseVisualStyleBackColor = true;
            this.btnESC.Click += new System.EventHandler(this.btnESC_Click);
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(251, 58);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1030, 660);
            this.homeControl1.TabIndex = 4;
            // 
            // aboutForm1
            // 
            this.aboutForm1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutForm1.Location = new System.Drawing.Point(251, 57);
            this.aboutForm1.Name = "aboutForm1";
            this.aboutForm1.Size = new System.Drawing.Size(1030, 663);
            this.aboutForm1.TabIndex = 2;
            // 
            // editFoodForm1
            // 
            this.editFoodForm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editFoodForm1.Location = new System.Drawing.Point(251, 57);
            this.editFoodForm1.Name = "editFoodForm1";
            this.editFoodForm1.Size = new System.Drawing.Size(1030, 660);
            this.editFoodForm1.TabIndex = 3;
            // 
            // menuForm1
            // 
            this.menuForm1.Location = new System.Drawing.Point(251, 57);
            this.menuForm1.Name = "menuForm1";
            this.menuForm1.Size = new System.Drawing.Size(1030, 663);
            this.menuForm1.TabIndex = 4;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(251, 57);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1030, 663);
            this.homeUserControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnESC;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.menuForm1);
            this.Controls.Add(this.editFoodForm1);
            this.Controls.Add(this.aboutForm1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftSidePanel);
            this.Name = "MainForm";
            this.LeftSidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label2;
        private HomeUserControl homeControl1;
        private System.Windows.Forms.Button btnMinimize;
        private AboutForm aboutForm1;
        private EditFoodForm editFoodForm1;
        private MenuForm menuForm1;
        private HomeUserControl homeUserControl1;
    }
}

