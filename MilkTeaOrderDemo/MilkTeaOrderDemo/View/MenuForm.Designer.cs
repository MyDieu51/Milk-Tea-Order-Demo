﻿namespace MilkTeaOrderDemo
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panListOrder = new System.Windows.Forms.Panel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.panListOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panMenu.Controls.Add(this.panel1);
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(717, 660);
            this.panMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(707, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 660);
            this.panel1.TabIndex = 0;
            // 
            // panListOrder
            // 
            this.panListOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panListOrder.Controls.Add(this.btnPrintInvoice);
            this.panListOrder.Controls.Add(this.dgvOrder);
            this.panListOrder.Controls.Add(this.label3);
            this.panListOrder.Controls.Add(this.txtTime);
            this.panListOrder.Controls.Add(this.txtDate);
            this.panListOrder.Controls.Add(this.label5);
            this.panListOrder.Controls.Add(this.label4);
            this.panListOrder.Controls.Add(this.txtVAT);
            this.panListOrder.Controls.Add(this.label2);
            this.panListOrder.Controls.Add(this.txtTotal);
            this.panListOrder.Controls.Add(this.label1);
            this.panListOrder.Location = new System.Drawing.Point(717, 0);
            this.panListOrder.Name = "panListOrder";
            this.panListOrder.Size = new System.Drawing.Size(312, 660);
            this.panListOrder.TabIndex = 1;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.Khaki;
            this.btnPrintInvoice.FlatAppearance.BorderSize = 0;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(117, 595);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(75, 40);
            this.btnPrintInvoice.TabIndex = 22;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvOrder.DataSource = this.invoiceDetailBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.Location = new System.Drawing.Point(0, 216);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.Size = new System.Drawing.Size(312, 273);
            this.dgvOrder.TabIndex = 12;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "Food Name";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodNameDataGridViewTextBoxColumn.Width = 169;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 30;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 70;
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Del";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Del";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 30;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataSource = typeof(MilkTeaOrderDemo.InvoiceDetail);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Korean Cuisine";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(103, 178);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 20);
            this.txtTime.TabIndex = 20;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(103, 136);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 20);
            this.txtDate.TabIndex = 19;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(148, 513);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(141, 19);
            this.txtVAT.TabIndex = 16;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "VAT (10%)";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(148, 554);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(141, 24);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panListOrder);
            this.Controls.Add(this.panMenu);
            this.Name = "MenuForm";
            this.Size = new System.Drawing.Size(1030, 663);
            this.panMenu.ResumeLayout(false);
            this.panListOrder.ResumeLayout(false);
            this.panListOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panListOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}
