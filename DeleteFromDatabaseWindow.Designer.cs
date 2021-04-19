namespace VarnishMixApp
{
    partial class DeleteFromDatabaseWindow
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
            this.tabControlDeleteFromDatabase = new System.Windows.Forms.TabControl();
            this.tabPageDeleteWithRelated = new System.Windows.Forms.TabPage();
            this.buttonDeleteBaseProductWithRelated = new System.Windows.Forms.Button();
            this.comboBoxBaseProducts = new System.Windows.Forms.ComboBox();
            this.dataGridViewBaseProductsWithRelated = new System.Windows.Forms.DataGridView();
            this.tabPageDeleteSelected = new System.Windows.Forms.TabPage();
            this.buttonDeleteSelectedAdditional = new System.Windows.Forms.Button();
            this.comboBoxBaseProductsSelected = new System.Windows.Forms.ComboBox();
            this.dataGridViewAdditional = new System.Windows.Forms.DataGridView();
            this.dataGridViewBaseProducts = new System.Windows.Forms.DataGridView();
            this.tabControlDeleteFromDatabase.SuspendLayout();
            this.tabPageDeleteWithRelated.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProductsWithRelated)).BeginInit();
            this.tabPageDeleteSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdditional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDeleteFromDatabase
            // 
            this.tabControlDeleteFromDatabase.Controls.Add(this.tabPageDeleteWithRelated);
            this.tabControlDeleteFromDatabase.Controls.Add(this.tabPageDeleteSelected);
            this.tabControlDeleteFromDatabase.Location = new System.Drawing.Point(13, 13);
            this.tabControlDeleteFromDatabase.Name = "tabControlDeleteFromDatabase";
            this.tabControlDeleteFromDatabase.SelectedIndex = 0;
            this.tabControlDeleteFromDatabase.Size = new System.Drawing.Size(775, 425);
            this.tabControlDeleteFromDatabase.TabIndex = 0;
            // 
            // tabPageDeleteWithRelated
            // 
            this.tabPageDeleteWithRelated.Controls.Add(this.buttonDeleteBaseProductWithRelated);
            this.tabPageDeleteWithRelated.Controls.Add(this.comboBoxBaseProducts);
            this.tabPageDeleteWithRelated.Controls.Add(this.dataGridViewBaseProductsWithRelated);
            this.tabPageDeleteWithRelated.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteWithRelated.Name = "tabPageDeleteWithRelated";
            this.tabPageDeleteWithRelated.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteWithRelated.Size = new System.Drawing.Size(767, 399);
            this.tabPageDeleteWithRelated.TabIndex = 0;
            this.tabPageDeleteWithRelated.Text = "Bazowe + powiązane";
            this.tabPageDeleteWithRelated.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBaseProductWithRelated
            // 
            this.buttonDeleteBaseProductWithRelated.Location = new System.Drawing.Point(7, 344);
            this.buttonDeleteBaseProductWithRelated.Name = "buttonDeleteBaseProductWithRelated";
            this.buttonDeleteBaseProductWithRelated.Size = new System.Drawing.Size(754, 49);
            this.buttonDeleteBaseProductWithRelated.TabIndex = 2;
            this.buttonDeleteBaseProductWithRelated.Text = "Usuń produkt bazowy razem z powiązanymi";
            this.buttonDeleteBaseProductWithRelated.UseVisualStyleBackColor = true;
            this.buttonDeleteBaseProductWithRelated.Click += new System.EventHandler(this.buttonDeleteBaseProductWithRelated_Click);
            // 
            // comboBoxBaseProducts
            // 
            this.comboBoxBaseProducts.FormattingEnabled = true;
            this.comboBoxBaseProducts.Location = new System.Drawing.Point(6, 18);
            this.comboBoxBaseProducts.Name = "comboBoxBaseProducts";
            this.comboBoxBaseProducts.Size = new System.Drawing.Size(242, 21);
            this.comboBoxBaseProducts.TabIndex = 1;
            this.comboBoxBaseProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaseProducts_SelectedIndexChanged);
            // 
            // dataGridViewBaseProductsWithRelated
            // 
            this.dataGridViewBaseProductsWithRelated.AllowUserToAddRows = false;
            this.dataGridViewBaseProductsWithRelated.AllowUserToDeleteRows = false;
            this.dataGridViewBaseProductsWithRelated.AllowUserToOrderColumns = true;
            this.dataGridViewBaseProductsWithRelated.AllowUserToResizeColumns = false;
            this.dataGridViewBaseProductsWithRelated.AllowUserToResizeRows = false;
            this.dataGridViewBaseProductsWithRelated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaseProductsWithRelated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaseProductsWithRelated.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewBaseProductsWithRelated.MultiSelect = false;
            this.dataGridViewBaseProductsWithRelated.Name = "dataGridViewBaseProductsWithRelated";
            this.dataGridViewBaseProductsWithRelated.ReadOnly = true;
            this.dataGridViewBaseProductsWithRelated.RowHeadersVisible = false;
            this.dataGridViewBaseProductsWithRelated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBaseProductsWithRelated.Size = new System.Drawing.Size(755, 283);
            this.dataGridViewBaseProductsWithRelated.TabIndex = 0;
            this.dataGridViewBaseProductsWithRelated.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaseProductsWithRelated_CellContentClick);
            // 
            // tabPageDeleteSelected
            // 
            this.tabPageDeleteSelected.Controls.Add(this.buttonDeleteSelectedAdditional);
            this.tabPageDeleteSelected.Controls.Add(this.comboBoxBaseProductsSelected);
            this.tabPageDeleteSelected.Controls.Add(this.dataGridViewAdditional);
            this.tabPageDeleteSelected.Controls.Add(this.dataGridViewBaseProducts);
            this.tabPageDeleteSelected.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteSelected.Name = "tabPageDeleteSelected";
            this.tabPageDeleteSelected.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeleteSelected.Size = new System.Drawing.Size(767, 399);
            this.tabPageDeleteSelected.TabIndex = 1;
            this.tabPageDeleteSelected.Text = "dodawane";
            this.tabPageDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelectedAdditional
            // 
            this.buttonDeleteSelectedAdditional.Location = new System.Drawing.Point(7, 323);
            this.buttonDeleteSelectedAdditional.Name = "buttonDeleteSelectedAdditional";
            this.buttonDeleteSelectedAdditional.Size = new System.Drawing.Size(753, 70);
            this.buttonDeleteSelectedAdditional.TabIndex = 3;
            this.buttonDeleteSelectedAdditional.Text = "Usuń zaznaczone produkty dodawane";
            this.buttonDeleteSelectedAdditional.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedAdditional.Click += new System.EventHandler(this.buttonDeleteSelectedAdditional_Click);
            // 
            // comboBoxBaseProductsSelected
            // 
            this.comboBoxBaseProductsSelected.FormattingEnabled = true;
            this.comboBoxBaseProductsSelected.Location = new System.Drawing.Point(7, 7);
            this.comboBoxBaseProductsSelected.Name = "comboBoxBaseProductsSelected";
            this.comboBoxBaseProductsSelected.Size = new System.Drawing.Size(192, 21);
            this.comboBoxBaseProductsSelected.TabIndex = 2;
            this.comboBoxBaseProductsSelected.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaseProductsSelected_SelectedIndexChanged);
            // 
            // dataGridViewAdditional
            // 
            this.dataGridViewAdditional.AllowUserToAddRows = false;
            this.dataGridViewAdditional.AllowUserToDeleteRows = false;
            this.dataGridViewAdditional.AllowUserToResizeColumns = false;
            this.dataGridViewAdditional.AllowUserToResizeRows = false;
            this.dataGridViewAdditional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdditional.Location = new System.Drawing.Point(368, 34);
            this.dataGridViewAdditional.Name = "dataGridViewAdditional";
            this.dataGridViewAdditional.ReadOnly = true;
            this.dataGridViewAdditional.RowHeadersVisible = false;
            this.dataGridViewAdditional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdditional.Size = new System.Drawing.Size(392, 283);
            this.dataGridViewAdditional.TabIndex = 1;
            this.dataGridViewAdditional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdditional_CellContentClick);
            // 
            // dataGridViewBaseProducts
            // 
            this.dataGridViewBaseProducts.AllowUserToAddRows = false;
            this.dataGridViewBaseProducts.AllowUserToDeleteRows = false;
            this.dataGridViewBaseProducts.AllowUserToResizeColumns = false;
            this.dataGridViewBaseProducts.AllowUserToResizeRows = false;
            this.dataGridViewBaseProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaseProducts.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewBaseProducts.MultiSelect = false;
            this.dataGridViewBaseProducts.Name = "dataGridViewBaseProducts";
            this.dataGridViewBaseProducts.ReadOnly = true;
            this.dataGridViewBaseProducts.RowHeadersVisible = false;
            this.dataGridViewBaseProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBaseProducts.Size = new System.Drawing.Size(356, 283);
            this.dataGridViewBaseProducts.TabIndex = 0;
            this.dataGridViewBaseProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaseProducts_CellContentClick);
            this.dataGridViewBaseProducts.SelectionChanged += new System.EventHandler(this.dataGridViewBaseProducts_SelectionChanged);
            // 
            // DeleteFromDatabaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDeleteFromDatabase);
            this.Name = "DeleteFromDatabaseWindow";
            this.Text = "DeleteFromDatabase";
            this.Load += new System.EventHandler(this.DeleteFromDatabase_Load);
            this.tabControlDeleteFromDatabase.ResumeLayout(false);
            this.tabPageDeleteWithRelated.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProductsWithRelated)).EndInit();
            this.tabPageDeleteSelected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdditional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaseProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDeleteFromDatabase;
        private System.Windows.Forms.TabPage tabPageDeleteWithRelated;
        private System.Windows.Forms.TabPage tabPageDeleteSelected;
        private System.Windows.Forms.Button buttonDeleteBaseProductWithRelated;
        private System.Windows.Forms.ComboBox comboBoxBaseProducts;
        private System.Windows.Forms.DataGridView dataGridViewBaseProductsWithRelated;
        private System.Windows.Forms.Button buttonDeleteSelectedAdditional;
        private System.Windows.Forms.ComboBox comboBoxBaseProductsSelected;
        private System.Windows.Forms.DataGridView dataGridViewAdditional;
        private System.Windows.Forms.DataGridView dataGridViewBaseProducts;
    }
}