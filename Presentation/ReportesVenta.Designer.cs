namespace Presentation
{
    partial class ReportesVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesVenta));
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelOver = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Spr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnthisYear = new System.Windows.Forms.Button();
            this.btnlast30days = new System.Windows.Forms.Button();
            this.thisMonth = new System.Windows.Forms.Button();
            this.btnLastWeaK = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            this.panelOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Logic.SalesReport);
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(Logic.SalesListing);
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(Logic.NetSalesByPeriod);
            // 
            // panelOver
            // 
            this.panelOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.panelOver.Controls.Add(this.label2);
            this.panelOver.Controls.Add(this.pictureBox1);
            this.panelOver.Controls.Add(this.button1);
            this.panelOver.Controls.Add(this.btnClose);
            this.panelOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOver.ForeColor = System.Drawing.Color.White;
            this.panelOver.Location = new System.Drawing.Point(0, 0);
            this.panelOver.Name = "panelOver";
            this.panelOver.Size = new System.Drawing.Size(888, 29);
            this.panelOver.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categorias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.LOGOCODE1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentation.Properties.Resources.Icono_Minimizar;
            this.button1.Location = new System.Drawing.Point(832, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Presentation.Properties.Resources.Icono_cerrar_FN;
            this.btnClose.Location = new System.Drawing.Point(860, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Spr
            // 
            this.Spr.HeaderText = "";
            this.Spr.Name = "Spr";
            this.Spr.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Controls.Add(this.btnCaja);
            this.panel1.Controls.Add(this.btnthisYear);
            this.panel1.Controls.Add(this.btnlast30days);
            this.panel1.Controls.Add(this.thisMonth);
            this.panel1.Controls.Add(this.btnLastWeaK);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 594);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Desde:";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(92, 427);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerToDate.TabIndex = 38;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(92, 385);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerFromDate.TabIndex = 37;
            // 
            // btnCaja
            // 
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(18, 470);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(228, 40);
            this.btnCaja.TabIndex = 36;
            this.btnCaja.Text = "Aplicar Filtro";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnthisYear
            // 
            this.btnthisYear.FlatAppearance.BorderSize = 0;
            this.btnthisYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnthisYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnthisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthisYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthisYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthisYear.Location = new System.Drawing.Point(18, 305);
            this.btnthisYear.Name = "btnthisYear";
            this.btnthisYear.Size = new System.Drawing.Size(228, 40);
            this.btnthisYear.TabIndex = 30;
            this.btnthisYear.Text = "Este Año";
            this.btnthisYear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnthisYear.UseVisualStyleBackColor = true;
            this.btnthisYear.Click += new System.EventHandler(this.btnthisYear_Click);
            // 
            // btnlast30days
            // 
            this.btnlast30days.FlatAppearance.BorderSize = 0;
            this.btnlast30days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnlast30days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlast30days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast30days.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast30days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlast30days.Location = new System.Drawing.Point(18, 249);
            this.btnlast30days.Name = "btnlast30days";
            this.btnlast30days.Size = new System.Drawing.Size(228, 40);
            this.btnlast30days.TabIndex = 31;
            this.btnlast30days.Text = "Ultimos 30 Dìas";
            this.btnlast30days.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlast30days.UseVisualStyleBackColor = true;
            this.btnlast30days.Click += new System.EventHandler(this.btnlast30days_Click);
            // 
            // thisMonth
            // 
            this.thisMonth.FlatAppearance.BorderSize = 0;
            this.thisMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.thisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisMonth.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thisMonth.Location = new System.Drawing.Point(18, 197);
            this.thisMonth.Name = "thisMonth";
            this.thisMonth.Size = new System.Drawing.Size(228, 40);
            this.thisMonth.TabIndex = 34;
            this.thisMonth.Text = "Este Mes";
            this.thisMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.thisMonth.UseVisualStyleBackColor = true;
            this.thisMonth.Click += new System.EventHandler(this.thisMonth_Click);
            // 
            // btnLastWeaK
            // 
            this.btnLastWeaK.FlatAppearance.BorderSize = 0;
            this.btnLastWeaK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLastWeaK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLastWeaK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastWeaK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastWeaK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLastWeaK.Location = new System.Drawing.Point(20, 142);
            this.btnLastWeaK.Name = "btnLastWeaK";
            this.btnLastWeaK.Size = new System.Drawing.Size(228, 40);
            this.btnLastWeaK.TabIndex = 32;
            this.btnLastWeaK.Text = "Ùltima Semana";
            this.btnLastWeaK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLastWeaK.UseVisualStyleBackColor = true;
            this.btnLastWeaK.Click += new System.EventHandler(this.btnLastWeaK_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(20, 86);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(228, 40);
            this.btnToday.TabIndex = 35;
            this.btnToday.Text = "Hoy";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesReport";
            reportDataSource1.Value = this.SalesReportBindingSource;
            reportDataSource2.Name = "SalesListing";
            reportDataSource2.Value = this.SalesListingBindingSource;
            reportDataSource3.Name = "NetSalesByPeriod";
            reportDataSource3.Value = this.NetSalesByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reporting.Salesreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(270, 29);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(618, 594);
            this.reportViewer1.TabIndex = 8;
            // 
            // ReportesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.BackGround_Big1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 623);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOver);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportesVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesVenta";
            this.Load += new System.EventHandler(this.ReportesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            this.panelOver.ResumeLayout(false);
            this.panelOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Spr;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnthisYear;
        private System.Windows.Forms.Button btnlast30days;
        private System.Windows.Forms.Button thisMonth;
        private System.Windows.Forms.Button btnLastWeaK;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}