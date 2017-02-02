namespace Engine.UI
{
    partial class MainUI
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.lblCalcPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCalcQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCalcProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCalcCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.btnProdNew = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabRebate = new System.Windows.Forms.TabPage();
            this.cmbRebName = new System.Windows.Forms.ComboBox();
            this.btnRebNew = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRebDiscount = new System.Windows.Forms.TextBox();
            this.pnlRebSeasonal = new System.Windows.Forms.Panel();
            this.dateRebSeasonalEnd = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateRebSeasonalStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlRebSpecial = new System.Windows.Forms.Panel();
            this.dateRebSpecialEnd = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dateRebSpecialStart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRebSpecialQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReb = new System.Windows.Forms.Button();
            this.pnlRebVolume = new System.Windows.Forms.Panel();
            this.txtRebVolQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbRebVolume = new System.Windows.Forms.RadioButton();
            this.rdbRebSpecial = new System.Windows.Forms.RadioButton();
            this.rdbRebSeasonal = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRebProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRebName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.cmbCusName = new System.Windows.Forms.ComboBox();
            this.btnCusNew = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.chkCusAgreements = new System.Windows.Forms.CheckedListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.gridRebate = new System.Windows.Forms.DataGridView();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabRebate.SuspendLayout();
            this.pnlRebSeasonal.SuspendLayout();
            this.pnlRebSpecial.SuspendLayout();
            this.pnlRebVolume.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRebate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCalculator);
            this.tabMain.Controls.Add(this.tabProduct);
            this.tabMain.Controls.Add(this.tabRebate);
            this.tabMain.Controls.Add(this.tabCustomer);
            this.tabMain.Controls.Add(this.tabManage);
            this.tabMain.Location = new System.Drawing.Point(12, 76);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(559, 302);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_TabIndexChanged);
            this.tabMain.TabIndexChanged += new System.EventHandler(this.tabMain_TabIndexChanged);
            // 
            // tabCalculator
            // 
            this.tabCalculator.Controls.Add(this.lblCalcPrice);
            this.tabCalculator.Controls.Add(this.label5);
            this.tabCalculator.Controls.Add(this.btnCalc);
            this.tabCalculator.Controls.Add(this.txtCalcQuantity);
            this.tabCalculator.Controls.Add(this.label4);
            this.tabCalculator.Controls.Add(this.cmbCalcProduct);
            this.tabCalculator.Controls.Add(this.label3);
            this.tabCalculator.Controls.Add(this.cmbCalcCustomer);
            this.tabCalculator.Controls.Add(this.label2);
            this.tabCalculator.Location = new System.Drawing.Point(4, 22);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(551, 276);
            this.tabCalculator.TabIndex = 0;
            this.tabCalculator.Text = "Calculator";
            this.tabCalculator.UseVisualStyleBackColor = true;
            // 
            // lblCalcPrice
            // 
            this.lblCalcPrice.AutoSize = true;
            this.lblCalcPrice.Location = new System.Drawing.Point(148, 150);
            this.lblCalcPrice.Name = "lblCalcPrice";
            this.lblCalcPrice.Size = new System.Drawing.Size(66, 13);
            this.lblCalcPrice.TabIndex = 8;
            this.lblCalcPrice.Text = "0.00 per unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Discounted Price :";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(432, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(102, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCalcQuantity
            // 
            this.txtCalcQuantity.Location = new System.Drawing.Point(151, 106);
            this.txtCalcQuantity.Name = "txtCalcQuantity";
            this.txtCalcQuantity.Size = new System.Drawing.Size(102, 20);
            this.txtCalcQuantity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity :";
            // 
            // cmbCalcProduct
            // 
            this.cmbCalcProduct.DisplayMember = "Name";
            this.cmbCalcProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalcProduct.FormattingEnabled = true;
            this.cmbCalcProduct.Location = new System.Drawing.Point(151, 67);
            this.cmbCalcProduct.Name = "cmbCalcProduct";
            this.cmbCalcProduct.Size = new System.Drawing.Size(156, 21);
            this.cmbCalcProduct.TabIndex = 3;
            this.cmbCalcProduct.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product :";
            // 
            // cmbCalcCustomer
            // 
            this.cmbCalcCustomer.DisplayMember = "Name";
            this.cmbCalcCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalcCustomer.FormattingEnabled = true;
            this.cmbCalcCustomer.Location = new System.Drawing.Point(151, 28);
            this.cmbCalcCustomer.Name = "cmbCalcCustomer";
            this.cmbCalcCustomer.Size = new System.Drawing.Size(156, 21);
            this.cmbCalcCustomer.TabIndex = 1;
            this.cmbCalcCustomer.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer :";
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.cmbProdName);
            this.tabProduct.Controls.Add(this.btnProdNew);
            this.tabProduct.Controls.Add(this.btnProd);
            this.tabProduct.Controls.Add(this.txtProdPrice);
            this.tabProduct.Controls.Add(this.label11);
            this.tabProduct.Controls.Add(this.label10);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.label9);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(551, 276);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // cmbProdName
            // 
            this.cmbProdName.DisplayMember = "Name";
            this.cmbProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(151, 27);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(156, 21);
            this.cmbProdName.TabIndex = 7;
            this.cmbProdName.ValueMember = "Id";
            this.cmbProdName.SelectedIndexChanged += new System.EventHandler(this.cmbProdName_SelectedIndexChanged);
            // 
            // btnProdNew
            // 
            this.btnProdNew.BackgroundImage = global::Engine.Resource.add;
            this.btnProdNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdNew.Location = new System.Drawing.Point(313, 28);
            this.btnProdNew.Name = "btnProdNew";
            this.btnProdNew.Size = new System.Drawing.Size(20, 20);
            this.btnProdNew.TabIndex = 6;
            this.btnProdNew.UseVisualStyleBackColor = true;
            this.btnProdNew.Click += new System.EventHandler(this.btnProdNew_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(432, 238);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(102, 23);
            this.btnProd.TabIndex = 5;
            this.btnProd.Text = "Edit Product";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(151, 67);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProdPrice.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "per unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Standard Price :";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(151, 28);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(156, 20);
            this.txtProdName.TabIndex = 1;
            this.txtProdName.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Product Name :";
            // 
            // tabRebate
            // 
            this.tabRebate.Controls.Add(this.cmbRebName);
            this.tabRebate.Controls.Add(this.btnRebNew);
            this.tabRebate.Controls.Add(this.label19);
            this.tabRebate.Controls.Add(this.txtRebDiscount);
            this.tabRebate.Controls.Add(this.pnlRebSeasonal);
            this.tabRebate.Controls.Add(this.label18);
            this.tabRebate.Controls.Add(this.pnlRebSpecial);
            this.tabRebate.Controls.Add(this.btnReb);
            this.tabRebate.Controls.Add(this.pnlRebVolume);
            this.tabRebate.Controls.Add(this.panel1);
            this.tabRebate.Controls.Add(this.label8);
            this.tabRebate.Controls.Add(this.cmbRebProduct);
            this.tabRebate.Controls.Add(this.label7);
            this.tabRebate.Controls.Add(this.txtRebName);
            this.tabRebate.Controls.Add(this.label6);
            this.tabRebate.Location = new System.Drawing.Point(4, 22);
            this.tabRebate.Name = "tabRebate";
            this.tabRebate.Padding = new System.Windows.Forms.Padding(3);
            this.tabRebate.Size = new System.Drawing.Size(551, 276);
            this.tabRebate.TabIndex = 2;
            this.tabRebate.Text = "Rebate Agreement";
            this.tabRebate.UseVisualStyleBackColor = true;
            // 
            // cmbRebName
            // 
            this.cmbRebName.DisplayMember = "Name";
            this.cmbRebName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRebName.FormattingEnabled = true;
            this.cmbRebName.Location = new System.Drawing.Point(151, 27);
            this.cmbRebName.Name = "cmbRebName";
            this.cmbRebName.Size = new System.Drawing.Size(156, 21);
            this.cmbRebName.TabIndex = 17;
            this.cmbRebName.ValueMember = "Id";
            this.cmbRebName.SelectedIndexChanged += new System.EventHandler(this.cmbRebName_SelectedIndexChanged);
            // 
            // btnRebNew
            // 
            this.btnRebNew.BackgroundImage = global::Engine.Properties.Resources.add;
            this.btnRebNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRebNew.Location = new System.Drawing.Point(313, 28);
            this.btnRebNew.Name = "btnRebNew";
            this.btnRebNew.Size = new System.Drawing.Size(20, 20);
            this.btnRebNew.TabIndex = 16;
            this.btnRebNew.UseVisualStyleBackColor = true;
            this.btnRebNew.Click += new System.EventHandler(this.btnRebNew_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(258, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "%";
            // 
            // txtRebDiscount
            // 
            this.txtRebDiscount.Location = new System.Drawing.Point(151, 107);
            this.txtRebDiscount.Name = "txtRebDiscount";
            this.txtRebDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtRebDiscount.TabIndex = 14;
            // 
            // pnlRebSeasonal
            // 
            this.pnlRebSeasonal.Controls.Add(this.dateRebSeasonalEnd);
            this.pnlRebSeasonal.Controls.Add(this.label14);
            this.pnlRebSeasonal.Controls.Add(this.dateRebSeasonalStart);
            this.pnlRebSeasonal.Controls.Add(this.label13);
            this.pnlRebSeasonal.Location = new System.Drawing.Point(33, 174);
            this.pnlRebSeasonal.Name = "pnlRebSeasonal";
            this.pnlRebSeasonal.Size = new System.Drawing.Size(429, 65);
            this.pnlRebSeasonal.TabIndex = 11;
            this.pnlRebSeasonal.Visible = false;
            // 
            // dateRebSeasonalEnd
            // 
            this.dateRebSeasonalEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRebSeasonalEnd.Location = new System.Drawing.Point(263, 8);
            this.dateRebSeasonalEnd.Name = "dateRebSeasonalEnd";
            this.dateRebSeasonalEnd.Size = new System.Drawing.Size(98, 20);
            this.dateRebSeasonalEnd.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "-";
            // 
            // dateRebSeasonalStart
            // 
            this.dateRebSeasonalStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRebSeasonalStart.Location = new System.Drawing.Point(120, 8);
            this.dateRebSeasonalStart.Name = "dateRebSeasonalStart";
            this.dateRebSeasonalStart.Size = new System.Drawing.Size(101, 20);
            this.dateRebSeasonalStart.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Period :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Discount :";
            // 
            // pnlRebSpecial
            // 
            this.pnlRebSpecial.Controls.Add(this.dateRebSpecialEnd);
            this.pnlRebSpecial.Controls.Add(this.label17);
            this.pnlRebSpecial.Controls.Add(this.dateRebSpecialStart);
            this.pnlRebSpecial.Controls.Add(this.label16);
            this.pnlRebSpecial.Controls.Add(this.txtRebSpecialQuantity);
            this.pnlRebSpecial.Controls.Add(this.label15);
            this.pnlRebSpecial.Location = new System.Drawing.Point(33, 174);
            this.pnlRebSpecial.Name = "pnlRebSpecial";
            this.pnlRebSpecial.Size = new System.Drawing.Size(429, 65);
            this.pnlRebSpecial.TabIndex = 12;
            this.pnlRebSpecial.Visible = false;
            // 
            // dateRebSpecialEnd
            // 
            this.dateRebSpecialEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRebSpecialEnd.Location = new System.Drawing.Point(263, 42);
            this.dateRebSpecialEnd.Name = "dateRebSpecialEnd";
            this.dateRebSpecialEnd.Size = new System.Drawing.Size(98, 20);
            this.dateRebSpecialEnd.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "-";
            // 
            // dateRebSpecialStart
            // 
            this.dateRebSpecialStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRebSpecialStart.Location = new System.Drawing.Point(121, 42);
            this.dateRebSpecialStart.Name = "dateRebSpecialStart";
            this.dateRebSpecialStart.Size = new System.Drawing.Size(100, 20);
            this.dateRebSpecialStart.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Period :";
            // 
            // txtRebSpecialQuantity
            // 
            this.txtRebSpecialQuantity.Location = new System.Drawing.Point(121, 9);
            this.txtRebSpecialQuantity.Name = "txtRebSpecialQuantity";
            this.txtRebSpecialQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtRebSpecialQuantity.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Minimal Quantity :";
            // 
            // btnReb
            // 
            this.btnReb.Location = new System.Drawing.Point(432, 238);
            this.btnReb.Name = "btnReb";
            this.btnReb.Size = new System.Drawing.Size(102, 23);
            this.btnReb.TabIndex = 10;
            this.btnReb.Text = "Edit Agreement";
            this.btnReb.UseVisualStyleBackColor = true;
            this.btnReb.Click += new System.EventHandler(this.btnReb_Click);
            // 
            // pnlRebVolume
            // 
            this.pnlRebVolume.Controls.Add(this.txtRebVolQuantity);
            this.pnlRebVolume.Controls.Add(this.label12);
            this.pnlRebVolume.Location = new System.Drawing.Point(33, 174);
            this.pnlRebVolume.Name = "pnlRebVolume";
            this.pnlRebVolume.Size = new System.Drawing.Size(429, 65);
            this.pnlRebVolume.TabIndex = 9;
            // 
            // txtRebVolQuantity
            // 
            this.txtRebVolQuantity.Location = new System.Drawing.Point(121, 9);
            this.txtRebVolQuantity.Name = "txtRebVolQuantity";
            this.txtRebVolQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtRebVolQuantity.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Minimum Quantity :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbRebVolume);
            this.panel1.Controls.Add(this.rdbRebSpecial);
            this.panel1.Controls.Add(this.rdbRebSeasonal);
            this.panel1.Location = new System.Drawing.Point(151, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 25);
            this.panel1.TabIndex = 8;
            // 
            // rdbRebVolume
            // 
            this.rdbRebVolume.AutoSize = true;
            this.rdbRebVolume.Checked = true;
            this.rdbRebVolume.Location = new System.Drawing.Point(3, 5);
            this.rdbRebVolume.Name = "rdbRebVolume";
            this.rdbRebVolume.Size = new System.Drawing.Size(93, 17);
            this.rdbRebVolume.TabIndex = 5;
            this.rdbRebVolume.TabStop = true;
            this.rdbRebVolume.Text = "Volume Based";
            this.rdbRebVolume.UseVisualStyleBackColor = true;
            this.rdbRebVolume.CheckedChanged += new System.EventHandler(this.rdbRebType_CheckedChanged);
            // 
            // rdbRebSpecial
            // 
            this.rdbRebSpecial.AutoSize = true;
            this.rdbRebSpecial.Location = new System.Drawing.Point(205, 5);
            this.rdbRebSpecial.Name = "rdbRebSpecial";
            this.rdbRebSpecial.Size = new System.Drawing.Size(86, 17);
            this.rdbRebSpecial.TabIndex = 7;
            this.rdbRebSpecial.Text = "Special Offer";
            this.rdbRebSpecial.UseVisualStyleBackColor = true;
            this.rdbRebSpecial.CheckedChanged += new System.EventHandler(this.rdbRebType_CheckedChanged);
            // 
            // rdbRebSeasonal
            // 
            this.rdbRebSeasonal.AutoSize = true;
            this.rdbRebSeasonal.Location = new System.Drawing.Point(116, 5);
            this.rdbRebSeasonal.Name = "rdbRebSeasonal";
            this.rdbRebSeasonal.Size = new System.Drawing.Size(69, 17);
            this.rdbRebSeasonal.TabIndex = 6;
            this.rdbRebSeasonal.Text = "Seasonal";
            this.rdbRebSeasonal.UseVisualStyleBackColor = true;
            this.rdbRebSeasonal.CheckedChanged += new System.EventHandler(this.rdbRebType_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rebate Type :";
            // 
            // cmbRebProduct
            // 
            this.cmbRebProduct.DisplayMember = "Name";
            this.cmbRebProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRebProduct.FormattingEnabled = true;
            this.cmbRebProduct.Location = new System.Drawing.Point(151, 67);
            this.cmbRebProduct.Name = "cmbRebProduct";
            this.cmbRebProduct.Size = new System.Drawing.Size(156, 21);
            this.cmbRebProduct.TabIndex = 3;
            this.cmbRebProduct.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Product :";
            // 
            // txtRebName
            // 
            this.txtRebName.Location = new System.Drawing.Point(151, 28);
            this.txtRebName.Name = "txtRebName";
            this.txtRebName.Size = new System.Drawing.Size(156, 20);
            this.txtRebName.TabIndex = 1;
            this.txtRebName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Agreement Name :";
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.cmbCusName);
            this.tabCustomer.Controls.Add(this.btnCusNew);
            this.tabCustomer.Controls.Add(this.btnCus);
            this.tabCustomer.Controls.Add(this.chkCusAgreements);
            this.tabCustomer.Controls.Add(this.label21);
            this.tabCustomer.Controls.Add(this.txtCusName);
            this.tabCustomer.Controls.Add(this.label20);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(551, 276);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // cmbCusName
            // 
            this.cmbCusName.DisplayMember = "Name";
            this.cmbCusName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCusName.FormattingEnabled = true;
            this.cmbCusName.Location = new System.Drawing.Point(151, 27);
            this.cmbCusName.Name = "cmbCusName";
            this.cmbCusName.Size = new System.Drawing.Size(156, 21);
            this.cmbCusName.TabIndex = 6;
            this.cmbCusName.ValueMember = "Id";
            this.cmbCusName.SelectedIndexChanged += new System.EventHandler(this.cmbCusName_SelectedIndexChanged);
            // 
            // btnCusNew
            // 
            this.btnCusNew.BackgroundImage = global::Engine.Properties.Resources.add;
            this.btnCusNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCusNew.Location = new System.Drawing.Point(313, 28);
            this.btnCusNew.Name = "btnCusNew";
            this.btnCusNew.Size = new System.Drawing.Size(20, 20);
            this.btnCusNew.TabIndex = 5;
            this.btnCusNew.UseVisualStyleBackColor = true;
            this.btnCusNew.Click += new System.EventHandler(this.btnCusNew_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(432, 238);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(102, 23);
            this.btnCus.TabIndex = 4;
            this.btnCus.Text = "Edit Customer";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // chkCusAgreements
            // 
            this.chkCusAgreements.DisplayMember = "Name";
            this.chkCusAgreements.FormattingEnabled = true;
            this.chkCusAgreements.Location = new System.Drawing.Point(151, 69);
            this.chkCusAgreements.Name = "chkCusAgreements";
            this.chkCusAgreements.Size = new System.Drawing.Size(283, 124);
            this.chkCusAgreements.TabIndex = 3;
            this.chkCusAgreements.ValueMember = "Id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Rebate Agreements :";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(151, 28);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(156, 20);
            this.txtCusName.TabIndex = 1;
            this.txtCusName.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Customer Name :";
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.cmbCategory);
            this.tabManage.Controls.Add(this.label22);
            this.tabManage.Controls.Add(this.gridRebate);
            this.tabManage.Controls.Add(this.gridCustomer);
            this.tabManage.Controls.Add(this.gridProduct);
            this.tabManage.Location = new System.Drawing.Point(4, 22);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(551, 276);
            this.tabManage.TabIndex = 4;
            this.tabManage.Text = "Manage";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(151, 28);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Category :";
            // 
            // gridRebate
            // 
            this.gridRebate.AllowUserToAddRows = false;
            this.gridRebate.AllowUserToDeleteRows = false;
            this.gridRebate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRebate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridRebate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridRebate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRebate.Location = new System.Drawing.Point(6, 65);
            this.gridRebate.MultiSelect = false;
            this.gridRebate.Name = "gridRebate";
            this.gridRebate.ReadOnly = true;
            this.gridRebate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRebate.Size = new System.Drawing.Size(539, 205);
            this.gridRebate.TabIndex = 2;
            this.gridRebate.Visible = false;
            this.gridRebate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRebate_CellContentClick);
            this.gridRebate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseClick);
            // 
            // gridCustomer
            // 
            this.gridCustomer.AllowUserToAddRows = false;
            this.gridCustomer.AllowUserToDeleteRows = false;
            this.gridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Location = new System.Drawing.Point(6, 65);
            this.gridCustomer.MultiSelect = false;
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.ReadOnly = true;
            this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomer.Size = new System.Drawing.Size(539, 205);
            this.gridCustomer.TabIndex = 1;
            this.gridCustomer.Visible = false;
            this.gridCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseClick);
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Location = new System.Drawing.Point(6, 65);
            this.gridProduct.MultiSelect = false;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduct.Size = new System.Drawing.Size(539, 205);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.Visible = false;
            this.gridProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(385, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price Calculator";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Engine.Resource.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(33, 17);
            this.txtStatus.Text = "Ready..";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatus.Text = "Ready..";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(583, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabMain);
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Calculator";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.tabMain.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.tabRebate.ResumeLayout(false);
            this.tabRebate.PerformLayout();
            this.pnlRebSeasonal.ResumeLayout(false);
            this.pnlRebSeasonal.PerformLayout();
            this.pnlRebSpecial.ResumeLayout(false);
            this.pnlRebSpecial.PerformLayout();
            this.pnlRebVolume.ResumeLayout(false);
            this.pnlRebVolume.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.tabManage.ResumeLayout(false);
            this.tabManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRebate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCalculator;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRebate;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.Label lblCalcPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCalcQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCalcProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCalcCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRebDiscount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlRebSpecial;
        private System.Windows.Forms.DateTimePicker dateRebSpecialEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateRebSpecialStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRebSpecialQuantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlRebSeasonal;
        private System.Windows.Forms.DateTimePicker dateRebSeasonalEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateRebSeasonalStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReb;
        private System.Windows.Forms.Panel pnlRebVolume;
        private System.Windows.Forms.TextBox txtRebVolQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbRebVolume;
        private System.Windows.Forms.RadioButton rdbRebSpecial;
        private System.Windows.Forms.RadioButton rdbRebSeasonal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRebProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRebName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.CheckedListBox chkCusAgreements;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.DataGridView gridRebate;
        private System.Windows.Forms.DataGridView gridCustomer;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.Button btnProdNew;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ComboBox cmbRebName;
        private System.Windows.Forms.Button btnRebNew;
        private System.Windows.Forms.ComboBox cmbCusName;
        private System.Windows.Forms.Button btnCusNew;
    }
}