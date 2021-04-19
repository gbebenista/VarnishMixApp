namespace VarnishMixApp
{
    partial class AddToDatabaseWindow
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
            this.textBoxBaseProductName = new System.Windows.Forms.TextBox();
            this.comboBoxBaseProductType = new System.Windows.Forms.ComboBox();
            this.labelBaseProductName = new System.Windows.Forms.Label();
            this.labelBaseProductType = new System.Windows.Forms.Label();
            this.groupBoxAdditionalRequired = new System.Windows.Forms.GroupBox();
            this.panelThinner = new System.Windows.Forms.Panel();
            this.labelByOneThinner = new System.Windows.Forms.Label();
            this.label1PercentThinner = new System.Windows.Forms.Label();
            this.labelDivisionProportionThinner = new System.Windows.Forms.Label();
            this.labelWeightProportionThinner = new System.Windows.Forms.Label();
            this.textBoxThinnerName = new System.Windows.Forms.TextBox();
            this.numericUpDownDivisionProportionThinner = new System.Windows.Forms.NumericUpDown();
            this.labelThinnerName = new System.Windows.Forms.Label();
            this.numericUpDownWeightProportionThinner = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPercentProportionThinner = new System.Windows.Forms.NumericUpDown();
            this.label1PercentProportionThinner = new System.Windows.Forms.Label();
            this.panelHardener = new System.Windows.Forms.Panel();
            this.labelByOneHardener = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelDivisionProportionHardener = new System.Windows.Forms.Label();
            this.labelWeightProportionHardener = new System.Windows.Forms.Label();
            this.numericUpDownDivisionProportionHardener = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeightProportionHardener = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPercentProportionHardener = new System.Windows.Forms.NumericUpDown();
            this.labelPercentProportionHardener = new System.Windows.Forms.Label();
            this.labelHardenerName = new System.Windows.Forms.Label();
            this.textBoxHardenerName = new System.Windows.Forms.TextBox();
            this.checkBoxHardener = new System.Windows.Forms.CheckBox();
            this.checkBoxThinner = new System.Windows.Forms.CheckBox();
            this.groupBoxBaseProductData = new System.Windows.Forms.GroupBox();
            this.tabControlAddToDatabase = new System.Windows.Forms.TabControl();
            this.tabPageAddBaseAndRequired = new System.Windows.Forms.TabPage();
            this.buttonAddToDatabaseBaseAndRequired = new System.Windows.Forms.Button();
            this.tabPageAddAdditional = new System.Windows.Forms.TabPage();
            this.buttonAddAdditionalProduct = new System.Windows.Forms.Button();
            this.labelByOneAdditional = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelDivisionProportionAdditional = new System.Windows.Forms.Label();
            this.labelWeightProportionAdditional = new System.Windows.Forms.Label();
            this.numericUpDownDivisionAdditional = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeightProportionAdditional = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPercentProportionAdditional = new System.Windows.Forms.NumericUpDown();
            this.labelPercentProportionAdditional = new System.Windows.Forms.Label();
            this.labelAdditionalProductName = new System.Windows.Forms.Label();
            this.textBoxAdditionalProductName = new System.Windows.Forms.TextBox();
            this.panelHardenerOrThinner = new System.Windows.Forms.Panel();
            this.radioButtonThinner = new System.Windows.Forms.RadioButton();
            this.radioButtonHardener = new System.Windows.Forms.RadioButton();
            this.radioButtonOptional = new System.Windows.Forms.RadioButton();
            this.radioButtonRequired = new System.Windows.Forms.RadioButton();
            this.comboBoxBaseProduct = new System.Windows.Forms.ComboBox();
            this.dataGridViewBaseProductSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxAdditionalRequired.SuspendLayout();
            this.panelThinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionProportionThinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionThinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionThinner)).BeginInit();
            this.panelHardener.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionProportionHardener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionHardener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionHardener)).BeginInit();
            this.groupBoxBaseProductData.SuspendLayout();
            this.tabControlAddToDatabase.SuspendLayout();
            this.tabPageAddBaseAndRequired.SuspendLayout();
            this.tabPageAddAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionAdditional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionAdditional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionAdditional)).BeginInit();
            this.panelHardenerOrThinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProductSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBaseProductName
            // 
            this.textBoxBaseProductName.Location = new System.Drawing.Point(6, 44);
            this.textBoxBaseProductName.Name = "textBoxBaseProductName";
            this.textBoxBaseProductName.Size = new System.Drawing.Size(220, 20);
            this.textBoxBaseProductName.TabIndex = 1;
            this.textBoxBaseProductName.TextChanged += new System.EventHandler(this.textBoxBaseProductName_TextChanged);
            // 
            // comboBoxBaseProductType
            // 
            this.comboBoxBaseProductType.FormattingEnabled = true;
            this.comboBoxBaseProductType.Location = new System.Drawing.Point(281, 44);
            this.comboBoxBaseProductType.Name = "comboBoxBaseProductType";
            this.comboBoxBaseProductType.Size = new System.Drawing.Size(250, 21);
            this.comboBoxBaseProductType.TabIndex = 2;
            // 
            // labelBaseProductName
            // 
            this.labelBaseProductName.AutoSize = true;
            this.labelBaseProductName.Location = new System.Drawing.Point(6, 25);
            this.labelBaseProductName.Name = "labelBaseProductName";
            this.labelBaseProductName.Size = new System.Drawing.Size(40, 13);
            this.labelBaseProductName.TabIndex = 3;
            this.labelBaseProductName.Text = "Nazwa";
            // 
            // labelBaseProductType
            // 
            this.labelBaseProductType.AutoSize = true;
            this.labelBaseProductType.Location = new System.Drawing.Point(283, 25);
            this.labelBaseProductType.Name = "labelBaseProductType";
            this.labelBaseProductType.Size = new System.Drawing.Size(25, 13);
            this.labelBaseProductType.TabIndex = 4;
            this.labelBaseProductType.Text = "Typ";
            // 
            // groupBoxAdditionalRequired
            // 
            this.groupBoxAdditionalRequired.Controls.Add(this.panelThinner);
            this.groupBoxAdditionalRequired.Controls.Add(this.panelHardener);
            this.groupBoxAdditionalRequired.Controls.Add(this.checkBoxHardener);
            this.groupBoxAdditionalRequired.Controls.Add(this.checkBoxThinner);
            this.groupBoxAdditionalRequired.Location = new System.Drawing.Point(6, 89);
            this.groupBoxAdditionalRequired.Name = "groupBoxAdditionalRequired";
            this.groupBoxAdditionalRequired.Size = new System.Drawing.Size(544, 299);
            this.groupBoxAdditionalRequired.TabIndex = 5;
            this.groupBoxAdditionalRequired.TabStop = false;
            this.groupBoxAdditionalRequired.Text = "Produkty dodawane";
            // 
            // panelThinner
            // 
            this.panelThinner.Controls.Add(this.labelByOneThinner);
            this.panelThinner.Controls.Add(this.label1PercentThinner);
            this.panelThinner.Controls.Add(this.labelDivisionProportionThinner);
            this.panelThinner.Controls.Add(this.labelWeightProportionThinner);
            this.panelThinner.Controls.Add(this.textBoxThinnerName);
            this.panelThinner.Controls.Add(this.numericUpDownDivisionProportionThinner);
            this.panelThinner.Controls.Add(this.labelThinnerName);
            this.panelThinner.Controls.Add(this.numericUpDownWeightProportionThinner);
            this.panelThinner.Controls.Add(this.numericUpDownPercentProportionThinner);
            this.panelThinner.Controls.Add(this.label1PercentProportionThinner);
            this.panelThinner.Enabled = false;
            this.panelThinner.Location = new System.Drawing.Point(275, 50);
            this.panelThinner.Name = "panelThinner";
            this.panelThinner.Size = new System.Drawing.Size(256, 243);
            this.panelThinner.TabIndex = 1;
            // 
            // labelByOneThinner
            // 
            this.labelByOneThinner.AutoSize = true;
            this.labelByOneThinner.Location = new System.Drawing.Point(48, 220);
            this.labelByOneThinner.Name = "labelByOneThinner";
            this.labelByOneThinner.Size = new System.Drawing.Size(19, 13);
            this.labelByOneThinner.TabIndex = 12;
            this.labelByOneThinner.Text = ": 1";
            // 
            // label1PercentThinner
            // 
            this.label1PercentThinner.AutoSize = true;
            this.label1PercentThinner.Location = new System.Drawing.Point(131, 121);
            this.label1PercentThinner.Name = "label1PercentThinner";
            this.label1PercentThinner.Size = new System.Drawing.Size(15, 13);
            this.label1PercentThinner.TabIndex = 11;
            this.label1PercentThinner.Text = "%";
            // 
            // labelDivisionProportionThinner
            // 
            this.labelDivisionProportionThinner.AutoSize = true;
            this.labelDivisionProportionThinner.Location = new System.Drawing.Point(3, 199);
            this.labelDivisionProportionThinner.Name = "labelDivisionProportionThinner";
            this.labelDivisionProportionThinner.Size = new System.Drawing.Size(144, 13);
            this.labelDivisionProportionThinner.TabIndex = 10;
            this.labelDivisionProportionThinner.Text = "Proporcja ilorazowa ( np. 2:1)";
            // 
            // labelWeightProportionThinner
            // 
            this.labelWeightProportionThinner.AutoSize = true;
            this.labelWeightProportionThinner.Location = new System.Drawing.Point(3, 152);
            this.labelWeightProportionThinner.Name = "labelWeightProportionThinner";
            this.labelWeightProportionThinner.Size = new System.Drawing.Size(146, 13);
            this.labelWeightProportionThinner.TabIndex = 9;
            this.labelWeightProportionThinner.Text = "Proporcja wagowa ( na 100g)";
            // 
            // textBoxThinnerName
            // 
            this.textBoxThinnerName.Location = new System.Drawing.Point(5, 21);
            this.textBoxThinnerName.Name = "textBoxThinnerName";
            this.textBoxThinnerName.Size = new System.Drawing.Size(220, 20);
            this.textBoxThinnerName.TabIndex = 1;
            // 
            // numericUpDownDivisionProportionThinner
            // 
            this.numericUpDownDivisionProportionThinner.Location = new System.Drawing.Point(5, 218);
            this.numericUpDownDivisionProportionThinner.Name = "numericUpDownDivisionProportionThinner";
            this.numericUpDownDivisionProportionThinner.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownDivisionProportionThinner.TabIndex = 8;
            // 
            // labelThinnerName
            // 
            this.labelThinnerName.AutoSize = true;
            this.labelThinnerName.Location = new System.Drawing.Point(2, 5);
            this.labelThinnerName.Name = "labelThinnerName";
            this.labelThinnerName.Size = new System.Drawing.Size(40, 13);
            this.labelThinnerName.TabIndex = 3;
            this.labelThinnerName.Text = "Nazwa";
            // 
            // numericUpDownWeightProportionThinner
            // 
            this.numericUpDownWeightProportionThinner.Location = new System.Drawing.Point(5, 171);
            this.numericUpDownWeightProportionThinner.Name = "numericUpDownWeightProportionThinner";
            this.numericUpDownWeightProportionThinner.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeightProportionThinner.TabIndex = 8;
            // 
            // numericUpDownPercentProportionThinner
            // 
            this.numericUpDownPercentProportionThinner.Location = new System.Drawing.Point(5, 119);
            this.numericUpDownPercentProportionThinner.Name = "numericUpDownPercentProportionThinner";
            this.numericUpDownPercentProportionThinner.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPercentProportionThinner.TabIndex = 7;
            // 
            // label1PercentProportionThinner
            // 
            this.label1PercentProportionThinner.AutoSize = true;
            this.label1PercentProportionThinner.Location = new System.Drawing.Point(2, 103);
            this.label1PercentProportionThinner.Name = "label1PercentProportionThinner";
            this.label1PercentProportionThinner.Size = new System.Drawing.Size(111, 13);
            this.label1PercentProportionThinner.TabIndex = 6;
            this.label1PercentProportionThinner.Text = "Proporcja procentowa";
            // 
            // panelHardener
            // 
            this.panelHardener.Controls.Add(this.labelByOneHardener);
            this.panelHardener.Controls.Add(this.labelPercent);
            this.panelHardener.Controls.Add(this.labelDivisionProportionHardener);
            this.panelHardener.Controls.Add(this.labelWeightProportionHardener);
            this.panelHardener.Controls.Add(this.numericUpDownDivisionProportionHardener);
            this.panelHardener.Controls.Add(this.numericUpDownWeightProportionHardener);
            this.panelHardener.Controls.Add(this.numericUpDownPercentProportionHardener);
            this.panelHardener.Controls.Add(this.labelPercentProportionHardener);
            this.panelHardener.Controls.Add(this.labelHardenerName);
            this.panelHardener.Controls.Add(this.textBoxHardenerName);
            this.panelHardener.Enabled = false;
            this.panelHardener.Location = new System.Drawing.Point(10, 50);
            this.panelHardener.Name = "panelHardener";
            this.panelHardener.Size = new System.Drawing.Size(262, 243);
            this.panelHardener.TabIndex = 0;
            // 
            // labelByOneHardener
            // 
            this.labelByOneHardener.AutoSize = true;
            this.labelByOneHardener.Location = new System.Drawing.Point(48, 220);
            this.labelByOneHardener.Name = "labelByOneHardener";
            this.labelByOneHardener.Size = new System.Drawing.Size(19, 13);
            this.labelByOneHardener.TabIndex = 12;
            this.labelByOneHardener.Text = ": 1";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(131, 121);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(15, 13);
            this.labelPercent.TabIndex = 11;
            this.labelPercent.Text = "%";
            // 
            // labelDivisionProportionHardener
            // 
            this.labelDivisionProportionHardener.AutoSize = true;
            this.labelDivisionProportionHardener.Location = new System.Drawing.Point(3, 199);
            this.labelDivisionProportionHardener.Name = "labelDivisionProportionHardener";
            this.labelDivisionProportionHardener.Size = new System.Drawing.Size(144, 13);
            this.labelDivisionProportionHardener.TabIndex = 10;
            this.labelDivisionProportionHardener.Text = "Proporcja ilorazowa ( np. 2:1)";
            // 
            // labelWeightProportionHardener
            // 
            this.labelWeightProportionHardener.AutoSize = true;
            this.labelWeightProportionHardener.Location = new System.Drawing.Point(3, 152);
            this.labelWeightProportionHardener.Name = "labelWeightProportionHardener";
            this.labelWeightProportionHardener.Size = new System.Drawing.Size(146, 13);
            this.labelWeightProportionHardener.TabIndex = 9;
            this.labelWeightProportionHardener.Text = "Proporcja wagowa ( na 100g)";
            // 
            // numericUpDownDivisionProportionHardener
            // 
            this.numericUpDownDivisionProportionHardener.Location = new System.Drawing.Point(5, 218);
            this.numericUpDownDivisionProportionHardener.Name = "numericUpDownDivisionProportionHardener";
            this.numericUpDownDivisionProportionHardener.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownDivisionProportionHardener.TabIndex = 8;
            // 
            // numericUpDownWeightProportionHardener
            // 
            this.numericUpDownWeightProportionHardener.Location = new System.Drawing.Point(5, 171);
            this.numericUpDownWeightProportionHardener.Name = "numericUpDownWeightProportionHardener";
            this.numericUpDownWeightProportionHardener.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeightProportionHardener.TabIndex = 8;
            // 
            // numericUpDownPercentProportionHardener
            // 
            this.numericUpDownPercentProportionHardener.Location = new System.Drawing.Point(5, 119);
            this.numericUpDownPercentProportionHardener.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPercentProportionHardener.Name = "numericUpDownPercentProportionHardener";
            this.numericUpDownPercentProportionHardener.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPercentProportionHardener.TabIndex = 7;
            this.numericUpDownPercentProportionHardener.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelPercentProportionHardener
            // 
            this.labelPercentProportionHardener.AutoSize = true;
            this.labelPercentProportionHardener.Location = new System.Drawing.Point(2, 103);
            this.labelPercentProportionHardener.Name = "labelPercentProportionHardener";
            this.labelPercentProportionHardener.Size = new System.Drawing.Size(111, 13);
            this.labelPercentProportionHardener.TabIndex = 6;
            this.labelPercentProportionHardener.Text = "Proporcja procentowa";
            // 
            // labelHardenerName
            // 
            this.labelHardenerName.AutoSize = true;
            this.labelHardenerName.Location = new System.Drawing.Point(3, 5);
            this.labelHardenerName.Name = "labelHardenerName";
            this.labelHardenerName.Size = new System.Drawing.Size(40, 13);
            this.labelHardenerName.TabIndex = 3;
            this.labelHardenerName.Text = "Nazwa";
            // 
            // textBoxHardenerName
            // 
            this.textBoxHardenerName.Location = new System.Drawing.Point(5, 21);
            this.textBoxHardenerName.Name = "textBoxHardenerName";
            this.textBoxHardenerName.Size = new System.Drawing.Size(220, 20);
            this.textBoxHardenerName.TabIndex = 1;
            // 
            // checkBoxHardener
            // 
            this.checkBoxHardener.AutoSize = true;
            this.checkBoxHardener.Location = new System.Drawing.Point(10, 27);
            this.checkBoxHardener.Name = "checkBoxHardener";
            this.checkBoxHardener.Size = new System.Drawing.Size(82, 17);
            this.checkBoxHardener.TabIndex = 0;
            this.checkBoxHardener.Text = "Utwardzacz";
            this.checkBoxHardener.UseVisualStyleBackColor = true;
            this.checkBoxHardener.CheckedChanged += new System.EventHandler(this.checkBoxBaseProductType_CheckedChanged);
            // 
            // checkBoxThinner
            // 
            this.checkBoxThinner.AutoSize = true;
            this.checkBoxThinner.Location = new System.Drawing.Point(275, 27);
            this.checkBoxThinner.Name = "checkBoxThinner";
            this.checkBoxThinner.Size = new System.Drawing.Size(98, 17);
            this.checkBoxThinner.TabIndex = 0;
            this.checkBoxThinner.Text = "Rozcienczalnik";
            this.checkBoxThinner.UseVisualStyleBackColor = true;
            this.checkBoxThinner.CheckedChanged += new System.EventHandler(this.checkBoxBaseProduct_CheckedChanged);
            // 
            // groupBoxBaseProductData
            // 
            this.groupBoxBaseProductData.Controls.Add(this.textBoxBaseProductName);
            this.groupBoxBaseProductData.Controls.Add(this.comboBoxBaseProductType);
            this.groupBoxBaseProductData.Controls.Add(this.labelBaseProductType);
            this.groupBoxBaseProductData.Controls.Add(this.labelBaseProductName);
            this.groupBoxBaseProductData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBaseProductData.Name = "groupBoxBaseProductData";
            this.groupBoxBaseProductData.Size = new System.Drawing.Size(544, 77);
            this.groupBoxBaseProductData.TabIndex = 6;
            this.groupBoxBaseProductData.TabStop = false;
            this.groupBoxBaseProductData.Text = "Produkt  bazowy";
            // 
            // tabControlAddToDatabase
            // 
            this.tabControlAddToDatabase.Controls.Add(this.tabPageAddBaseAndRequired);
            this.tabControlAddToDatabase.Controls.Add(this.tabPageAddAdditional);
            this.tabControlAddToDatabase.Location = new System.Drawing.Point(12, 12);
            this.tabControlAddToDatabase.Name = "tabControlAddToDatabase";
            this.tabControlAddToDatabase.SelectedIndex = 0;
            this.tabControlAddToDatabase.Size = new System.Drawing.Size(568, 481);
            this.tabControlAddToDatabase.TabIndex = 7;
            // 
            // tabPageAddBaseAndRequired
            // 
            this.tabPageAddBaseAndRequired.Controls.Add(this.buttonAddToDatabaseBaseAndRequired);
            this.tabPageAddBaseAndRequired.Controls.Add(this.groupBoxBaseProductData);
            this.tabPageAddBaseAndRequired.Controls.Add(this.groupBoxAdditionalRequired);
            this.tabPageAddBaseAndRequired.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddBaseAndRequired.Name = "tabPageAddBaseAndRequired";
            this.tabPageAddBaseAndRequired.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddBaseAndRequired.Size = new System.Drawing.Size(560, 455);
            this.tabPageAddBaseAndRequired.TabIndex = 0;
            this.tabPageAddBaseAndRequired.Text = "Bazowy + wymagane";
            this.tabPageAddBaseAndRequired.UseVisualStyleBackColor = true;
            // 
            // buttonAddToDatabaseBaseAndRequired
            // 
            this.buttonAddToDatabaseBaseAndRequired.Enabled = false;
            this.buttonAddToDatabaseBaseAndRequired.Location = new System.Drawing.Point(12, 394);
            this.buttonAddToDatabaseBaseAndRequired.Name = "buttonAddToDatabaseBaseAndRequired";
            this.buttonAddToDatabaseBaseAndRequired.Size = new System.Drawing.Size(538, 55);
            this.buttonAddToDatabaseBaseAndRequired.TabIndex = 7;
            this.buttonAddToDatabaseBaseAndRequired.Text = "Dodaj do bazy danych";
            this.buttonAddToDatabaseBaseAndRequired.UseVisualStyleBackColor = true;
            this.buttonAddToDatabaseBaseAndRequired.Click += new System.EventHandler(this.buttonAddToDatabaseBaseAndRequired_Click);
            // 
            // tabPageAddAdditional
            // 
            this.tabPageAddAdditional.Controls.Add(this.buttonAddAdditionalProduct);
            this.tabPageAddAdditional.Controls.Add(this.labelByOneAdditional);
            this.tabPageAddAdditional.Controls.Add(this.label16);
            this.tabPageAddAdditional.Controls.Add(this.labelDivisionProportionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.labelWeightProportionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.numericUpDownDivisionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.numericUpDownWeightProportionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.numericUpDownPercentProportionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.labelPercentProportionAdditional);
            this.tabPageAddAdditional.Controls.Add(this.labelAdditionalProductName);
            this.tabPageAddAdditional.Controls.Add(this.textBoxAdditionalProductName);
            this.tabPageAddAdditional.Controls.Add(this.panelHardenerOrThinner);
            this.tabPageAddAdditional.Controls.Add(this.radioButtonOptional);
            this.tabPageAddAdditional.Controls.Add(this.radioButtonRequired);
            this.tabPageAddAdditional.Controls.Add(this.comboBoxBaseProduct);
            this.tabPageAddAdditional.Controls.Add(this.dataGridViewBaseProductSelect);
            this.tabPageAddAdditional.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddAdditional.Name = "tabPageAddAdditional";
            this.tabPageAddAdditional.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddAdditional.Size = new System.Drawing.Size(560, 455);
            this.tabPageAddAdditional.TabIndex = 1;
            this.tabPageAddAdditional.Text = "Dodawane wymagane/opcjonalne";
            this.tabPageAddAdditional.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdditionalProduct
            // 
            this.buttonAddAdditionalProduct.Location = new System.Drawing.Point(6, 372);
            this.buttonAddAdditionalProduct.Name = "buttonAddAdditionalProduct";
            this.buttonAddAdditionalProduct.Size = new System.Drawing.Size(547, 77);
            this.buttonAddAdditionalProduct.TabIndex = 23;
            this.buttonAddAdditionalProduct.Text = "Dodaj produkt";
            this.buttonAddAdditionalProduct.UseVisualStyleBackColor = true;
            this.buttonAddAdditionalProduct.Click += new System.EventHandler(this.buttonAddAdditionalProduct_Click);
            // 
            // labelByOneAdditional
            // 
            this.labelByOneAdditional.AutoSize = true;
            this.labelByOneAdditional.Location = new System.Drawing.Point(449, 288);
            this.labelByOneAdditional.Name = "labelByOneAdditional";
            this.labelByOneAdditional.Size = new System.Drawing.Size(19, 13);
            this.labelByOneAdditional.TabIndex = 22;
            this.labelByOneAdditional.Text = ": 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "%";
            // 
            // labelDivisionProportionAdditional
            // 
            this.labelDivisionProportionAdditional.AutoSize = true;
            this.labelDivisionProportionAdditional.Location = new System.Drawing.Point(404, 270);
            this.labelDivisionProportionAdditional.Name = "labelDivisionProportionAdditional";
            this.labelDivisionProportionAdditional.Size = new System.Drawing.Size(144, 13);
            this.labelDivisionProportionAdditional.TabIndex = 20;
            this.labelDivisionProportionAdditional.Text = "Proporcja ilorazowa ( np. 2:1)";
            // 
            // labelWeightProportionAdditional
            // 
            this.labelWeightProportionAdditional.AutoSize = true;
            this.labelWeightProportionAdditional.Location = new System.Drawing.Point(244, 310);
            this.labelWeightProportionAdditional.Name = "labelWeightProportionAdditional";
            this.labelWeightProportionAdditional.Size = new System.Drawing.Size(146, 13);
            this.labelWeightProportionAdditional.TabIndex = 19;
            this.labelWeightProportionAdditional.Text = "Proporcja wagowa ( na 100g)";
            // 
            // numericUpDownDivisionAdditional
            // 
            this.numericUpDownDivisionAdditional.Location = new System.Drawing.Point(406, 286);
            this.numericUpDownDivisionAdditional.Name = "numericUpDownDivisionAdditional";
            this.numericUpDownDivisionAdditional.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownDivisionAdditional.TabIndex = 17;
            this.numericUpDownDivisionAdditional.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownWeightProportionAdditional
            // 
            this.numericUpDownWeightProportionAdditional.Location = new System.Drawing.Point(248, 329);
            this.numericUpDownWeightProportionAdditional.Name = "numericUpDownWeightProportionAdditional";
            this.numericUpDownWeightProportionAdditional.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeightProportionAdditional.TabIndex = 18;
            this.numericUpDownWeightProportionAdditional.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPercentProportionAdditional
            // 
            this.numericUpDownPercentProportionAdditional.Location = new System.Drawing.Point(248, 287);
            this.numericUpDownPercentProportionAdditional.Name = "numericUpDownPercentProportionAdditional";
            this.numericUpDownPercentProportionAdditional.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPercentProportionAdditional.TabIndex = 16;
            this.numericUpDownPercentProportionAdditional.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPercentProportionAdditional
            // 
            this.labelPercentProportionAdditional.AutoSize = true;
            this.labelPercentProportionAdditional.Location = new System.Drawing.Point(245, 270);
            this.labelPercentProportionAdditional.Name = "labelPercentProportionAdditional";
            this.labelPercentProportionAdditional.Size = new System.Drawing.Size(111, 13);
            this.labelPercentProportionAdditional.TabIndex = 15;
            this.labelPercentProportionAdditional.Text = "Proporcja procentowa";
            // 
            // labelAdditionalProductName
            // 
            this.labelAdditionalProductName.AutoSize = true;
            this.labelAdditionalProductName.Location = new System.Drawing.Point(6, 269);
            this.labelAdditionalProductName.Name = "labelAdditionalProductName";
            this.labelAdditionalProductName.Size = new System.Drawing.Size(40, 13);
            this.labelAdditionalProductName.TabIndex = 14;
            this.labelAdditionalProductName.Text = "Nazwa";
            // 
            // textBoxAdditionalProductName
            // 
            this.textBoxAdditionalProductName.Location = new System.Drawing.Point(7, 285);
            this.textBoxAdditionalProductName.Name = "textBoxAdditionalProductName";
            this.textBoxAdditionalProductName.Size = new System.Drawing.Size(209, 20);
            this.textBoxAdditionalProductName.TabIndex = 13;
            this.textBoxAdditionalProductName.TextChanged += new System.EventHandler(this.textBoxAdditionalProductName_TextChanged);
            // 
            // panelHardenerOrThinner
            // 
            this.panelHardenerOrThinner.Controls.Add(this.radioButtonThinner);
            this.panelHardenerOrThinner.Controls.Add(this.radioButtonHardener);
            this.panelHardenerOrThinner.Location = new System.Drawing.Point(102, 198);
            this.panelHardenerOrThinner.Name = "panelHardenerOrThinner";
            this.panelHardenerOrThinner.Size = new System.Drawing.Size(266, 25);
            this.panelHardenerOrThinner.TabIndex = 3;
            // 
            // radioButtonThinner
            // 
            this.radioButtonThinner.AutoSize = true;
            this.radioButtonThinner.Location = new System.Drawing.Point(166, 5);
            this.radioButtonThinner.Name = "radioButtonThinner";
            this.radioButtonThinner.Size = new System.Drawing.Size(97, 17);
            this.radioButtonThinner.TabIndex = 0;
            this.radioButtonThinner.Text = "Rozcieńczalnik";
            this.radioButtonThinner.UseVisualStyleBackColor = true;
            // 
            // radioButtonHardener
            // 
            this.radioButtonHardener.AutoSize = true;
            this.radioButtonHardener.Checked = true;
            this.radioButtonHardener.Location = new System.Drawing.Point(3, 5);
            this.radioButtonHardener.Name = "radioButtonHardener";
            this.radioButtonHardener.Size = new System.Drawing.Size(81, 17);
            this.radioButtonHardener.TabIndex = 0;
            this.radioButtonHardener.TabStop = true;
            this.radioButtonHardener.Text = "Utwardzacz";
            this.radioButtonHardener.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptional
            // 
            this.radioButtonOptional.AutoSize = true;
            this.radioButtonOptional.Location = new System.Drawing.Point(6, 233);
            this.radioButtonOptional.Name = "radioButtonOptional";
            this.radioButtonOptional.Size = new System.Drawing.Size(79, 17);
            this.radioButtonOptional.TabIndex = 2;
            this.radioButtonOptional.Text = "Opcjonalne";
            this.radioButtonOptional.UseVisualStyleBackColor = true;
            // 
            // radioButtonRequired
            // 
            this.radioButtonRequired.AutoSize = true;
            this.radioButtonRequired.Checked = true;
            this.radioButtonRequired.Location = new System.Drawing.Point(7, 203);
            this.radioButtonRequired.Name = "radioButtonRequired";
            this.radioButtonRequired.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRequired.TabIndex = 2;
            this.radioButtonRequired.TabStop = true;
            this.radioButtonRequired.Text = "Wymagane";
            this.radioButtonRequired.UseVisualStyleBackColor = true;
            this.radioButtonRequired.CheckedChanged += new System.EventHandler(this.radioButtonRequired_CheckedChanged);
            // 
            // comboBoxBaseProduct
            // 
            this.comboBoxBaseProduct.FormattingEnabled = true;
            this.comboBoxBaseProduct.Location = new System.Drawing.Point(7, 14);
            this.comboBoxBaseProduct.Name = "comboBoxBaseProduct";
            this.comboBoxBaseProduct.Size = new System.Drawing.Size(176, 21);
            this.comboBoxBaseProduct.TabIndex = 1;
            this.comboBoxBaseProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaseProduct_SelectedIndexChanged);
            // 
            // dataGridViewBaseProductSelect
            // 
            this.dataGridViewBaseProductSelect.AllowUserToAddRows = false;
            this.dataGridViewBaseProductSelect.AllowUserToDeleteRows = false;
            this.dataGridViewBaseProductSelect.AllowUserToOrderColumns = true;
            this.dataGridViewBaseProductSelect.AllowUserToResizeColumns = false;
            this.dataGridViewBaseProductSelect.AllowUserToResizeRows = false;
            this.dataGridViewBaseProductSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaseProductSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaseProductSelect.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewBaseProductSelect.MultiSelect = false;
            this.dataGridViewBaseProductSelect.Name = "dataGridViewBaseProductSelect";
            this.dataGridViewBaseProductSelect.ReadOnly = true;
            this.dataGridViewBaseProductSelect.RowHeadersVisible = false;
            this.dataGridViewBaseProductSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBaseProductSelect.Size = new System.Drawing.Size(547, 150);
            this.dataGridViewBaseProductSelect.TabIndex = 0;
            this.dataGridViewBaseProductSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaseProductSelect_CellContentClick);
            // 
            // AddToDatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 505);
            this.Controls.Add(this.tabControlAddToDatabase);
            this.Name = "AddToDatabaseWindow";
            this.Text = "AddToDatabaseForm";
            this.Load += new System.EventHandler(this.AddToDatabaseForm_Load);
            this.groupBoxAdditionalRequired.ResumeLayout(false);
            this.groupBoxAdditionalRequired.PerformLayout();
            this.panelThinner.ResumeLayout(false);
            this.panelThinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionProportionThinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionThinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionThinner)).EndInit();
            this.panelHardener.ResumeLayout(false);
            this.panelHardener.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionProportionHardener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionHardener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionHardener)).EndInit();
            this.groupBoxBaseProductData.ResumeLayout(false);
            this.groupBoxBaseProductData.PerformLayout();
            this.tabControlAddToDatabase.ResumeLayout(false);
            this.tabPageAddBaseAndRequired.ResumeLayout(false);
            this.tabPageAddAdditional.ResumeLayout(false);
            this.tabPageAddAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDivisionAdditional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightProportionAdditional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentProportionAdditional)).EndInit();
            this.panelHardenerOrThinner.ResumeLayout(false);
            this.panelHardenerOrThinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProductSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBaseProductName;
        private System.Windows.Forms.ComboBox comboBoxBaseProductType;
        private System.Windows.Forms.Label labelBaseProductName;
        private System.Windows.Forms.Label labelBaseProductType;
        private System.Windows.Forms.GroupBox groupBoxAdditionalRequired;
        private System.Windows.Forms.Panel panelThinner;
        private System.Windows.Forms.CheckBox checkBoxThinner;
        private System.Windows.Forms.Panel panelHardener;
        private System.Windows.Forms.CheckBox checkBoxHardener;
        private System.Windows.Forms.Label labelDivisionProportionHardener;
        private System.Windows.Forms.Label labelWeightProportionHardener;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisionProportionHardener;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightProportionHardener;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentProportionHardener;
        private System.Windows.Forms.Label labelPercentProportionHardener;
        private System.Windows.Forms.Label labelHardenerName;
        private System.Windows.Forms.TextBox textBoxHardenerName;
        private System.Windows.Forms.Label label1PercentThinner;
        private System.Windows.Forms.Label labelDivisionProportionThinner;
        private System.Windows.Forms.Label labelWeightProportionThinner;
        private System.Windows.Forms.TextBox textBoxThinnerName;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisionProportionThinner;
        private System.Windows.Forms.Label labelThinnerName;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightProportionThinner;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentProportionThinner;
        private System.Windows.Forms.Label label1PercentProportionThinner;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.GroupBox groupBoxBaseProductData;
        private System.Windows.Forms.TabControl tabControlAddToDatabase;
        private System.Windows.Forms.TabPage tabPageAddBaseAndRequired;
        private System.Windows.Forms.Button buttonAddToDatabaseBaseAndRequired;
        private System.Windows.Forms.TabPage tabPageAddAdditional;
        private System.Windows.Forms.Label labelByOneHardener;
        private System.Windows.Forms.Label labelByOneThinner;
        private System.Windows.Forms.Panel panelHardenerOrThinner;
        private System.Windows.Forms.RadioButton radioButtonThinner;
        private System.Windows.Forms.RadioButton radioButtonHardener;
        private System.Windows.Forms.RadioButton radioButtonOptional;
        private System.Windows.Forms.RadioButton radioButtonRequired;
        private System.Windows.Forms.ComboBox comboBoxBaseProduct;
        private System.Windows.Forms.DataGridView dataGridViewBaseProductSelect;
        private System.Windows.Forms.Button buttonAddAdditionalProduct;
        private System.Windows.Forms.Label labelByOneAdditional;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelDivisionProportionAdditional;
        private System.Windows.Forms.Label labelWeightProportionAdditional;
        private System.Windows.Forms.NumericUpDown numericUpDownDivisionAdditional;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightProportionAdditional;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentProportionAdditional;
        private System.Windows.Forms.Label labelPercentProportionAdditional;
        private System.Windows.Forms.Label labelAdditionalProductName;
        private System.Windows.Forms.TextBox textBoxAdditionalProductName;
    }
}