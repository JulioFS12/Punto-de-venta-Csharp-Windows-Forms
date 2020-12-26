namespace Presentation
{
    partial class PViewSuplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PViewSuplier));
            this.panelOver = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDocumentNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRegisteredName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMistake = new System.Windows.Forms.Label();
            this.txtIdSuplier = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNumberPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtWeb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.cbComercialSector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelOver.Size = new System.Drawing.Size(726, 29);
            this.panelOver.TabIndex = 38;
            this.panelOver.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOver_Paint);
            this.panelOver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelOver_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proveedores";
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
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentation.Properties.Resources.Icono_Minimizar;
            this.button1.Location = new System.Drawing.Point(670, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Presentation.Properties.Resources.Icono_cerrar_FN;
            this.btnClose.Location = new System.Drawing.Point(698, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDocumentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumentNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtDocumentNumber.HintText = "";
            this.txtDocumentNumber.isPassword = false;
            this.txtDocumentNumber.LineFocusedColor = System.Drawing.Color.Black;
            this.txtDocumentNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDocumentNumber.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtDocumentNumber.LineThickness = 3;
            this.txtDocumentNumber.Location = new System.Drawing.Point(181, 197);
            this.txtDocumentNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(161, 23);
            this.txtDocumentNumber.TabIndex = 37;
            this.txtDocumentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRegisteredName
            // 
            this.txtRegisteredName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisteredName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRegisteredName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegisteredName.HintForeColor = System.Drawing.Color.Empty;
            this.txtRegisteredName.HintText = "";
            this.txtRegisteredName.isPassword = false;
            this.txtRegisteredName.LineFocusedColor = System.Drawing.Color.Black;
            this.txtRegisteredName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRegisteredName.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtRegisteredName.LineThickness = 3;
            this.txtRegisteredName.Location = new System.Drawing.Point(182, 70);
            this.txtRegisteredName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisteredName.Name = "txtRegisteredName";
            this.txtRegisteredName.Size = new System.Drawing.Size(161, 23);
            this.txtRegisteredName.TabIndex = 36;
            this.txtRegisteredName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 20;
            this.btnNew.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.ActiveForecolor = System.Drawing.Color.White;
            this.btnNew.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "Nuevo";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 20;
            this.btnNew.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(202)))), ((int)(((byte)(162)))));
            this.btnNew.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.IdleLineColor = System.Drawing.Color.Gray;
            this.btnNew.Location = new System.Drawing.Point(54, 282);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(136, 40);
            this.btnNew.TabIndex = 35;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(54, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 17);
            this.lblDescription.TabIndex = 34;
            this.lblDescription.Text = "Sector Comercial *";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(84, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 17);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Razon Social *";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancelar";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(202)))), ((int)(((byte)(162)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.IdleLineColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(500, 282);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 40);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Guardar";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(202)))), ((int)(((byte)(162)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.IdleLineColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(354, 282);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 40);
            this.btnSave.TabIndex = 31;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Modificar";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(202)))), ((int)(((byte)(162)))));
            this.btnEdit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.IdleLineColor = System.Drawing.Color.Gray;
            this.btnEdit.Location = new System.Drawing.Point(206, 282);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 40);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblMistake
            // 
            this.lblMistake.AutoSize = true;
            this.lblMistake.BackColor = System.Drawing.Color.Transparent;
            this.lblMistake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMistake.Location = new System.Drawing.Point(240, 248);
            this.lblMistake.Name = "lblMistake";
            this.lblMistake.Size = new System.Drawing.Size(238, 17);
            this.lblMistake.TabIndex = 40;
            this.lblMistake.Text = "Por favor ingrese los datos obligatorios";
            // 
            // txtIdSuplier
            // 
            this.txtIdSuplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdSuplier.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdSuplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdSuplier.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdSuplier.HintText = "";
            this.txtIdSuplier.isPassword = false;
            this.txtIdSuplier.LineFocusedColor = System.Drawing.Color.Black;
            this.txtIdSuplier.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdSuplier.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtIdSuplier.LineThickness = 3;
            this.txtIdSuplier.Location = new System.Drawing.Point(354, 67);
            this.txtIdSuplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSuplier.Name = "txtIdSuplier";
            this.txtIdSuplier.Size = new System.Drawing.Size(24, 26);
            this.txtIdSuplier.TabIndex = 39;
            this.txtIdSuplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdSuplier.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Black;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(492, 156);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumberPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumberPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumberPhone.HintText = "";
            this.txtNumberPhone.isPassword = false;
            this.txtNumberPhone.LineFocusedColor = System.Drawing.Color.Black;
            this.txtNumberPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumberPhone.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtNumberPhone.LineThickness = 3;
            this.txtNumberPhone.Location = new System.Drawing.Point(492, 115);
            this.txtNumberPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(161, 23);
            this.txtNumberPhone.TabIndex = 41;
            this.txtNumberPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtWeb
            // 
            this.txtWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeb.HintForeColor = System.Drawing.Color.Empty;
            this.txtWeb.HintText = "";
            this.txtWeb.isPassword = false;
            this.txtWeb.LineFocusedColor = System.Drawing.Color.Black;
            this.txtWeb.LineIdleColor = System.Drawing.Color.Gray;
            this.txtWeb.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtWeb.LineThickness = 3;
            this.txtWeb.Location = new System.Drawing.Point(492, 195);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(161, 23);
            this.txtWeb.TabIndex = 44;
            this.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Black;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(492, 74);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 23);
            this.txtAddress.TabIndex = 43;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Items.AddRange(new object[] {
            "RIF",
            "CI"});
            this.cbDocumentType.Location = new System.Drawing.Point(182, 159);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(160, 25);
            this.cbDocumentType.TabIndex = 45;
            // 
            // cbComercialSector
            // 
            this.cbComercialSector.FormattingEnabled = true;
            this.cbComercialSector.Items.AddRange(new object[] {
            "Alimmentaciòn",
            "Agronomìa",
            "Fasmacologìa",
            "Medicina",
            "Limpieza"});
            this.cbComercialSector.Location = new System.Drawing.Point(182, 115);
            this.cbComercialSector.Name = "cbComercialSector";
            this.cbComercialSector.Size = new System.Drawing.Size(160, 25);
            this.cbComercialSector.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(84, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo de Doc *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(68, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nº Documento *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(432, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Web ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(436, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Email ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(417, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Telèfono *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(419, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Direcciòn";
            // 
            // PViewSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.BackGround_Big1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComercialSector);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumberPhone);
            this.Controls.Add(this.panelOver);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.txtRegisteredName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblMistake);
            this.Controls.Add(this.txtIdSuplier);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PViewSuplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PViewSuplier_FormClosing);
            this.Load += new System.EventHandler(this.PViewSuplier_Load);
            this.panelOver.ResumeLayout(false);
            this.panelOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDocumentNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRegisteredName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private System.Windows.Forms.Label lblMistake;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdSuplier;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumberPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtWeb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.ComboBox cbComercialSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}