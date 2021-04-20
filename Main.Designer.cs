namespace VarnishMixApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBaseProducts = new System.Windows.Forms.GroupBox();
            this.dataGridViewBaseProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxBaseProducts = new System.Windows.Forms.ComboBox();
            this.groupBoxRequired = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHardeners = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewThinners = new System.Windows.Forms.DataGridView();
            this.groupBoxOptional = new System.Windows.Forms.GroupBox();
            this.dataGridViewOptionals = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAddedRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.buttonMakeCalculations = new System.Windows.Forms.Button();
            this.groupBoxCalculations = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panelCalculations = new System.Windows.Forms.Panel();
            this.radioButtonWholeCapacity = new System.Windows.Forms.RadioButton();
            this.radioButtonBaseCapacity = new System.Windows.Forms.RadioButton();
            this.panelWhichCalculations = new System.Windows.Forms.Panel();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWeight = new System.Windows.Forms.CheckBox();
            this.buttonGeneratePDF = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResultBaseTitle = new System.Windows.Forms.Label();
            this.labelResultBaseProduct = new System.Windows.Forms.Label();
            this.labelCapacityResultTitle = new System.Windows.Forms.Label();
            this.labelResultWeightTitle = new System.Windows.Forms.Label();
            this.labelCapacityResult = new System.Windows.Forms.Label();
            this.labelWeightResult = new System.Windows.Forms.Label();
            this.groupBoxBaseProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProducts)).BeginInit();
            this.groupBoxRequired.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardeners)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThinners)).BeginInit();
            this.groupBoxOptional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptionals)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.groupBoxCalculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panelCalculations.SuspendLayout();
            this.panelWhichCalculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBaseProducts
            // 
            this.groupBoxBaseProducts.Controls.Add(this.dataGridViewBaseProducts);
            this.groupBoxBaseProducts.Controls.Add(this.comboBoxBaseProducts);
            this.groupBoxBaseProducts.Location = new System.Drawing.Point(13, 27);
            this.groupBoxBaseProducts.Name = "groupBoxBaseProducts";
            this.groupBoxBaseProducts.Size = new System.Drawing.Size(887, 255);
            this.groupBoxBaseProducts.TabIndex = 0;
            this.groupBoxBaseProducts.TabStop = false;
            this.groupBoxBaseProducts.Text = "Produkt bazowy";
            // 
            // dataGridViewBaseProducts
            // 
            this.dataGridViewBaseProducts.AllowUserToAddRows = false;
            this.dataGridViewBaseProducts.AllowUserToDeleteRows = false;
            this.dataGridViewBaseProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaseProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaseProducts.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewBaseProducts.MultiSelect = false;
            this.dataGridViewBaseProducts.Name = "dataGridViewBaseProducts";
            this.dataGridViewBaseProducts.ReadOnly = true;
            this.dataGridViewBaseProducts.RowHeadersVisible = false;
            this.dataGridViewBaseProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBaseProducts.Size = new System.Drawing.Size(875, 203);
            this.dataGridViewBaseProducts.TabIndex = 0;
            this.dataGridViewBaseProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaseProducts_CellClick);
            this.dataGridViewBaseProducts.SelectionChanged += new System.EventHandler(this.dataGridViewBaseProducts_SelectedRow);
            this.dataGridViewBaseProducts.MouseLeave += new System.EventHandler(this.dataGridViewCheckWeightProportion);
            // 
            // comboBoxBaseProducts
            // 
            this.comboBoxBaseProducts.FormattingEnabled = true;
            this.comboBoxBaseProducts.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBaseProducts.Name = "comboBoxBaseProducts";
            this.comboBoxBaseProducts.Size = new System.Drawing.Size(188, 21);
            this.comboBoxBaseProducts.TabIndex = 0;
            this.comboBoxBaseProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaseProducts_SelectedIndexChanged);
            // 
            // groupBoxRequired
            // 
            this.groupBoxRequired.Controls.Add(this.groupBox6);
            this.groupBoxRequired.Controls.Add(this.groupBox5);
            this.groupBoxRequired.Location = new System.Drawing.Point(12, 288);
            this.groupBoxRequired.Name = "groupBoxRequired";
            this.groupBoxRequired.Size = new System.Drawing.Size(445, 381);
            this.groupBoxRequired.TabIndex = 1;
            this.groupBoxRequired.TabStop = false;
            this.groupBoxRequired.Text = "Wymagane";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewHardeners);
            this.groupBox6.Location = new System.Drawing.Point(7, 209);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(432, 166);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Utwardzacze";
            // 
            // dataGridViewHardeners
            // 
            this.dataGridViewHardeners.AllowUserToAddRows = false;
            this.dataGridViewHardeners.AllowUserToDeleteRows = false;
            this.dataGridViewHardeners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHardeners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHardeners.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewHardeners.MultiSelect = false;
            this.dataGridViewHardeners.Name = "dataGridViewHardeners";
            this.dataGridViewHardeners.ReadOnly = true;
            this.dataGridViewHardeners.RowHeadersVisible = false;
            this.dataGridViewHardeners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHardeners.Size = new System.Drawing.Size(419, 140);
            this.dataGridViewHardeners.TabIndex = 0;
            this.dataGridViewHardeners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHardeners_CellClick);
            this.dataGridViewHardeners.MouseLeave += new System.EventHandler(this.dataGridViewCheckWeightProportion);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewThinners);
            this.groupBox5.Location = new System.Drawing.Point(7, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 182);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rozcienczalniki";
            // 
            // dataGridViewThinners
            // 
            this.dataGridViewThinners.AllowUserToAddRows = false;
            this.dataGridViewThinners.AllowUserToDeleteRows = false;
            this.dataGridViewThinners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThinners.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewThinners.MultiSelect = false;
            this.dataGridViewThinners.Name = "dataGridViewThinners";
            this.dataGridViewThinners.ReadOnly = true;
            this.dataGridViewThinners.RowHeadersVisible = false;
            this.dataGridViewThinners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThinners.Size = new System.Drawing.Size(420, 157);
            this.dataGridViewThinners.TabIndex = 0;
            this.dataGridViewThinners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThinners_CellClick);
            this.dataGridViewThinners.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewThinners_CellMouseClick);
            this.dataGridViewThinners.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewThinners_CellMouseDown);
            this.dataGridViewThinners.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewThinners_CellMouseUp);
            this.dataGridViewThinners.MouseLeave += new System.EventHandler(this.dataGridViewCheckWeightProportion);
            // 
            // groupBoxOptional
            // 
            this.groupBoxOptional.Controls.Add(this.dataGridViewOptionals);
            this.groupBoxOptional.Location = new System.Drawing.Point(463, 288);
            this.groupBoxOptional.Name = "groupBoxOptional";
            this.groupBoxOptional.Size = new System.Drawing.Size(437, 381);
            this.groupBoxOptional.TabIndex = 3;
            this.groupBoxOptional.TabStop = false;
            this.groupBoxOptional.Text = "Opcjonalne";
            // 
            // dataGridViewOptionals
            // 
            this.dataGridViewOptionals.AllowUserToAddRows = false;
            this.dataGridViewOptionals.AllowUserToDeleteRows = false;
            this.dataGridViewOptionals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOptionals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOptionals.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOptionals.Name = "dataGridViewOptionals";
            this.dataGridViewOptionals.ReadOnly = true;
            this.dataGridViewOptionals.RowHeadersVisible = false;
            this.dataGridViewOptionals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOptionals.Size = new System.Drawing.Size(424, 355);
            this.dataGridViewOptionals.TabIndex = 0;
            this.dataGridViewOptionals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOptionals_CellClick);
            this.dataGridViewOptionals.MouseLeave += new System.EventHandler(this.dataGridViewCheckWeightProportion);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1339, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.appToolStripMenuItem.Text = "Aplikacja";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "Resetuj";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.deleteAddedRecordToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.databaseToolStripMenuItem.Text = "Dane";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addRecordToolStripMenuItem.Text = "Dodaj do bazy";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // deleteAddedRecordToolStripMenuItem
            // 
            this.deleteAddedRecordToolStripMenuItem.Name = "deleteAddedRecordToolStripMenuItem";
            this.deleteAddedRecordToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteAddedRecordToolStripMenuItem.Text = "Usuń spośród dodanych";
            this.deleteAddedRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteAddedRecordToolStripMenuItem_Click);
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(78, 5);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(131, 20);
            this.numericUpDownCapacity.TabIndex = 4;
            // 
            // buttonMakeCalculations
            // 
            this.buttonMakeCalculations.Enabled = false;
            this.buttonMakeCalculations.Location = new System.Drawing.Point(221, 27);
            this.buttonMakeCalculations.Name = "buttonMakeCalculations";
            this.buttonMakeCalculations.Size = new System.Drawing.Size(173, 57);
            this.buttonMakeCalculations.TabIndex = 5;
            this.buttonMakeCalculations.Text = "Oblicz";
            this.buttonMakeCalculations.UseVisualStyleBackColor = true;
            this.buttonMakeCalculations.Click += new System.EventHandler(this.buttonMakeCalculations_Click);
            // 
            // groupBoxCalculations
            // 
            this.groupBoxCalculations.Controls.Add(this.groupBoxResult);
            this.groupBoxCalculations.Controls.Add(this.panelCalculations);
            this.groupBoxCalculations.Controls.Add(this.buttonGeneratePDF);
            this.groupBoxCalculations.Location = new System.Drawing.Point(906, 27);
            this.groupBoxCalculations.Name = "groupBoxCalculations";
            this.groupBoxCalculations.Size = new System.Drawing.Size(421, 642);
            this.groupBoxCalculations.TabIndex = 6;
            this.groupBoxCalculations.TabStop = false;
            this.groupBoxCalculations.Text = "Obliczenia";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(390, 378);
            this.dataGridViewResult.TabIndex = 15;
            // 
            // panelCalculations
            // 
            this.panelCalculations.Controls.Add(this.radioButtonWholeCapacity);
            this.panelCalculations.Controls.Add(this.radioButtonBaseCapacity);
            this.panelCalculations.Controls.Add(this.buttonMakeCalculations);
            this.panelCalculations.Controls.Add(this.panelWhichCalculations);
            this.panelCalculations.Location = new System.Drawing.Point(8, 19);
            this.panelCalculations.Name = "panelCalculations";
            this.panelCalculations.Size = new System.Drawing.Size(400, 91);
            this.panelCalculations.TabIndex = 14;
            // 
            // radioButtonWholeCapacity
            // 
            this.radioButtonWholeCapacity.AutoSize = true;
            this.radioButtonWholeCapacity.Location = new System.Drawing.Point(177, 4);
            this.radioButtonWholeCapacity.Name = "radioButtonWholeCapacity";
            this.radioButtonWholeCapacity.Size = new System.Drawing.Size(214, 17);
            this.radioButtonWholeCapacity.TabIndex = 8;
            this.radioButtonWholeCapacity.Text = "Całkowita ilość wymieszanego produktu";
            this.radioButtonWholeCapacity.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaseCapacity
            // 
            this.radioButtonBaseCapacity.AutoSize = true;
            this.radioButtonBaseCapacity.Checked = true;
            this.radioButtonBaseCapacity.Location = new System.Drawing.Point(6, 4);
            this.radioButtonBaseCapacity.Name = "radioButtonBaseCapacity";
            this.radioButtonBaseCapacity.Size = new System.Drawing.Size(144, 17);
            this.radioButtonBaseCapacity.TabIndex = 7;
            this.radioButtonBaseCapacity.TabStop = true;
            this.radioButtonBaseCapacity.Text = "Ilość produktu bazowego";
            this.radioButtonBaseCapacity.UseVisualStyleBackColor = true;
            // 
            // panelWhichCalculations
            // 
            this.panelWhichCalculations.Controls.Add(this.labelCapacity);
            this.panelWhichCalculations.Controls.Add(this.numericUpDownWeight);
            this.panelWhichCalculations.Controls.Add(this.checkBoxWeight);
            this.panelWhichCalculations.Controls.Add(this.numericUpDownCapacity);
            this.panelWhichCalculations.Location = new System.Drawing.Point(3, 27);
            this.panelWhichCalculations.Name = "panelWhichCalculations";
            this.panelWhichCalculations.Size = new System.Drawing.Size(212, 57);
            this.panelWhichCalculations.TabIndex = 11;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(4, 7);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(68, 13);
            this.labelCapacity.TabIndex = 12;
            this.labelCapacity.Text = "Objętość [ml]";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(78, 31);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(131, 20);
            this.numericUpDownWeight.TabIndex = 11;
            // 
            // checkBoxWeight
            // 
            this.checkBoxWeight.AutoSize = true;
            this.checkBoxWeight.Enabled = false;
            this.checkBoxWeight.Location = new System.Drawing.Point(7, 34);
            this.checkBoxWeight.Name = "checkBoxWeight";
            this.checkBoxWeight.Size = new System.Drawing.Size(70, 17);
            this.checkBoxWeight.TabIndex = 10;
            this.checkBoxWeight.Text = "Waga [g]";
            this.checkBoxWeight.UseVisualStyleBackColor = true;
            this.checkBoxWeight.CheckedChanged += new System.EventHandler(this.checkBoxWeight_CheckedChanged);
            // 
            // buttonGeneratePDF
            // 
            this.buttonGeneratePDF.Enabled = false;
            this.buttonGeneratePDF.Location = new System.Drawing.Point(13, 581);
            this.buttonGeneratePDF.Name = "buttonGeneratePDF";
            this.buttonGeneratePDF.Size = new System.Drawing.Size(395, 49);
            this.buttonGeneratePDF.TabIndex = 13;
            this.buttonGeneratePDF.Text = "Generuj raport";
            this.buttonGeneratePDF.UseVisualStyleBackColor = true;
            this.buttonGeneratePDF.Click += new System.EventHandler(this.buttonGeneratePDF_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelWeightResult);
            this.groupBoxResult.Controls.Add(this.labelCapacityResult);
            this.groupBoxResult.Controls.Add(this.labelResultWeightTitle);
            this.groupBoxResult.Controls.Add(this.labelCapacityResultTitle);
            this.groupBoxResult.Controls.Add(this.labelResultBaseProduct);
            this.groupBoxResult.Controls.Add(this.labelResultBaseTitle);
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Location = new System.Drawing.Point(6, 116);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(402, 459);
            this.groupBoxResult.TabIndex = 16;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Wyniki";
            // 
            // labelResultBaseTitle
            // 
            this.labelResultBaseTitle.AutoSize = true;
            this.labelResultBaseTitle.Location = new System.Drawing.Point(7, 20);
            this.labelResultBaseTitle.Name = "labelResultBaseTitle";
            this.labelResultBaseTitle.Size = new System.Drawing.Size(86, 13);
            this.labelResultBaseTitle.TabIndex = 16;
            this.labelResultBaseTitle.Text = "Produkt bazowy:";
            // 
            // labelResultBaseProduct
            // 
            this.labelResultBaseProduct.AutoSize = true;
            this.labelResultBaseProduct.Location = new System.Drawing.Point(100, 20);
            this.labelResultBaseProduct.Name = "labelResultBaseProduct";
            this.labelResultBaseProduct.Size = new System.Drawing.Size(0, 13);
            this.labelResultBaseProduct.TabIndex = 17;
            // 
            // labelCapacityResultTitle
            // 
            this.labelCapacityResultTitle.AutoSize = true;
            this.labelCapacityResultTitle.Location = new System.Drawing.Point(6, 42);
            this.labelCapacityResultTitle.Name = "labelCapacityResultTitle";
            this.labelCapacityResultTitle.Size = new System.Drawing.Size(71, 13);
            this.labelCapacityResultTitle.TabIndex = 18;
            this.labelCapacityResultTitle.Text = "Objętość [ml]:";
            // 
            // labelResultWeightTitle
            // 
            this.labelResultWeightTitle.AutoSize = true;
            this.labelResultWeightTitle.Location = new System.Drawing.Point(223, 42);
            this.labelResultWeightTitle.Name = "labelResultWeightTitle";
            this.labelResultWeightTitle.Size = new System.Drawing.Size(54, 13);
            this.labelResultWeightTitle.TabIndex = 19;
            this.labelResultWeightTitle.Text = "Waga [g]:";
            // 
            // labelCapacityResult
            // 
            this.labelCapacityResult.AutoSize = true;
            this.labelCapacityResult.Location = new System.Drawing.Point(100, 42);
            this.labelCapacityResult.Name = "labelCapacityResult";
            this.labelCapacityResult.Size = new System.Drawing.Size(0, 13);
            this.labelCapacityResult.TabIndex = 20;
            // 
            // labelWeightResult
            // 
            this.labelWeightResult.AutoSize = true;
            this.labelWeightResult.Location = new System.Drawing.Point(283, 42);
            this.labelWeightResult.Name = "labelWeightResult";
            this.labelWeightResult.Size = new System.Drawing.Size(0, 13);
            this.labelWeightResult.TabIndex = 21;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 676);
            this.Controls.Add(this.groupBoxCalculations);
            this.Controls.Add(this.groupBoxOptional);
            this.Controls.Add(this.groupBoxRequired);
            this.Controls.Add(this.groupBoxBaseProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VarnishMixApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBoxBaseProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProducts)).EndInit();
            this.groupBoxRequired.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardeners)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThinners)).EndInit();
            this.groupBoxOptional.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptionals)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.groupBoxCalculations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panelCalculations.ResumeLayout(false);
            this.panelCalculations.PerformLayout();
            this.panelWhichCalculations.ResumeLayout(false);
            this.panelWhichCalculations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBaseProducts;
        private System.Windows.Forms.GroupBox groupBoxRequired;
        private System.Windows.Forms.DataGridView dataGridViewBaseProducts;
        private System.Windows.Forms.GroupBox groupBoxOptional;
        private System.Windows.Forms.DataGridView dataGridViewOptionals;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxBaseProducts;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewThinners;
        private System.Windows.Forms.DataGridView dataGridViewHardeners;
        private System.Windows.Forms.Button buttonMakeCalculations;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.GroupBox groupBoxCalculations;
        private System.Windows.Forms.RadioButton radioButtonWholeCapacity;
        private System.Windows.Forms.RadioButton radioButtonBaseCapacity;
        private System.Windows.Forms.Panel panelWhichCalculations;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAddedRecordToolStripMenuItem;
        private System.Windows.Forms.Button buttonGeneratePDF;
        private System.Windows.Forms.Panel panelCalculations;
        private System.Windows.Forms.CheckBox checkBoxWeight;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelWeightResult;
        private System.Windows.Forms.Label labelCapacityResult;
        private System.Windows.Forms.Label labelResultWeightTitle;
        private System.Windows.Forms.Label labelCapacityResultTitle;
        private System.Windows.Forms.Label labelResultBaseProduct;
        private System.Windows.Forms.Label labelResultBaseTitle;
    }
}

