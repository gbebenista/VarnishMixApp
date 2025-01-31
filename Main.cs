﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace VarnishMixApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //załadowanie typów produktów bazowych do comboBox
        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBoxBaseProducts.DataSource = Enum.GetValues(typeof(BaseProductTypes));
            numericUpDownWeight.Enabled = false;

        }
        
        //przygotowanie tabeli z produktami bazowymi z wybranego typu (gdy tabela jest pusta, pozostałe funkcjonalności głównego okna są zablokowane)
        public void PrepareBaseProduct()
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewBaseProducts.DataSource = db.GetBaseProducts((BaseProductTypes)comboBoxBaseProducts.SelectedItem);
                }

                if (dataGridViewBaseProducts.Rows.Count == 0)
                {
                    dataGridViewOptionals.DataSource = null;
                    dataGridViewThinners.DataSource = null;
                    dataGridViewHardeners.DataSource = null;
                    buttonMakeCalculations.Enabled = false;
                    panelCalculations.Enabled = false;
                }
                else
                {
                    buttonMakeCalculations.Enabled = true;
                    panelCalculations.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabeli produktów bazowych. Proszę spróbować ponownie");
            }
        }

        private void comboBoxBaseProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareBaseProduct();
        }

        //przygotowuje tabele z danymi dotyczącymi produktów dodawanych
        public void PrepareAdditionalProducts()
        {
            try
            {
                int baseproductidvalue = Convert.ToInt32(dataGridViewBaseProducts.CurrentRow.Cells[0].Value);

                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewThinners.DataSource = db.GetAdditionalConstraintedThinner(baseproductidvalue);
                    dataGridViewHardeners.DataSource = db.GetAdditionalConstraintedHardener(baseproductidvalue);
                    dataGridViewOptionals.DataSource = db.GetAdditionalOther(baseproductidvalue);
                    dataGridViewOptionals.ClearSelection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabel z produktami dodawanymi. Proszę spróbować ponownie");
            }
        }


        private void dataGridViewBaseProducts_SelectedRow(object sender, EventArgs e)
        {
            PrepareAdditionalProducts();
        }

        //funkcja czyści wybrane pola tekstowe, sprawdza występowanie produktów dodawanych, w przypadku pomyślnego sprawdzenia wywołuje funkcję do pobrania proporcji oraz wykonania obliczeń.
        private void buttonMakeCalculations_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultBaseProduct.Text = "";
                labelCapacityResult.Text = "";
                labelWeightResult.Text = "";
                dataGridViewResult.DataSource = null;
                int baseproductidvalue = Convert.ToInt32(dataGridViewBaseProducts.CurrentRow.Cells[0].Value);
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    if (Validators.CheckIsAnyAdditionalProducts(baseproductidvalue, dataGridViewThinners.Rows.Count, dataGridViewHardeners.Rows.Count) == true)
                    {
                        //ogarnąć nullowe wartości
                        ProductProportionList productProportions = ProductProportionList.GetProductProportions(baseproductidvalue, dataGridViewOptionals.SelectedRows, (int?)dataGridViewThinners.CurrentRow.Cells[0].Value, (int?)(dataGridViewHardeners.CurrentRow.Cells[0].Value));

                        labelResultBaseProduct.Text = dataGridViewBaseProducts.CurrentRow.Cells[1].Value.ToString();
                        
                        if (radioButtonBaseCapacity.Checked == true)
                        {
                            dataGridViewResult.DataSource = CalculatedProductList.MakeCalculationWithBaseCapacity(productProportions, numericUpDownCapacity.Value, numericUpDownWeight.Value, checkBoxWeight.Checked);
                            labelCapacityResult.Text = numericUpDownCapacity.Value.ToString();
                            labelWeightResult.Text = numericUpDownWeight.Value.ToString();

                        }
                        else
                        {
                            dataGridViewResult.DataSource = CalculatedProductList.MakeCalculationWithWholeCapacity(productProportions, numericUpDownCapacity.Value, numericUpDownWeight.Value, checkBoxWeight.Checked);
                            List<decimal> basecapacityandweight = GetBaseCapacityFromWholeCapacity(numericUpDownCapacity.Value, numericUpDownWeight.Value, dataGridViewResult.Rows);
                            labelCapacityResult.Text = basecapacityandweight[0].ToString();
                            labelWeightResult.Text = basecapacityandweight[1].ToString();
                        }
                        buttonGeneratePDF.Enabled = true; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd podczas obliczania proporcji. Proszę spróbować ponownie");
            }


        }
        
        //pobiera wartość objętości i ewentualnej wagi w przypadku podania przez użytkownika tych wartości dla całkowitej ilości wymieszanego produktu. Nastepnie odejmuje objętości (opcjonalnie wagi) produktów dodawanych, z czego powstaje wartość dla produktu bazowego.
        public List<decimal> GetBaseCapacityFromWholeCapacity(decimal wholecapacity, decimal wholeweight, DataGridViewRowCollection dataGridViewRowCollection)
        {
            List<decimal> basefromwhole = new List<decimal> { wholecapacity, wholeweight };
            foreach (DataGridViewRow row in dataGridViewRowCollection)
            {
                basefromwhole[0] -= Convert.ToDecimal(row.Cells[1].Value);
                basefromwhole[1] -= Convert.ToDecimal(row.Cells[2].Value);
            }
            return basefromwhole;
        }

        private void dataGridViewCheckWeightProportion(object sender, EventArgs e)
        {
            if (dataGridViewBaseProducts.SelectedRows.Count == 0) return;
            checkBoxWeight.Enabled = IsWeightProportionPossible();
        }

        //funkcja sprawdza, czy jest możliwe obliczenie proporcji wagowej (jest to możliwe tylko jeśli wszystkie wybrane produkty zawierają wartość proporcji wagowej)
        public bool IsWeightProportionPossible()
        {
            try
            {
                decimal? thinner = 0;
                decimal? hardener = 0;
                decimal? optional = 0;

                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    if (dataGridViewBaseProducts.Rows.Count == 0) return false;

                    int baseproductidvalue = Convert.ToInt32(dataGridViewBaseProducts.CurrentRow.Cells[0].Value);

                    if (db.GetAnyThinner(baseproductidvalue) == true)
                    {
                        thinner = db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(dataGridViewThinners.CurrentRow.Cells[0].Value));
                    }

                    if (db.GetAnyHardener(baseproductidvalue) == true)
                    {
                        hardener = db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(dataGridViewHardeners.CurrentRow.Cells[0].Value));
                    }

                    if (db.GetAnyOptional(baseproductidvalue) == true)
                    {
                        foreach (DataGridViewRow row in dataGridViewOptionals.SelectedRows)
                        {
                            if (db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(row.Cells[0].Value)) == null) optional = null;
                        }
                    }

                }

                if (thinner != null && hardener != null && optional != null)
                {
                    checkBoxWeight.Checked = true;
                    return true;
                }
                else
                {
                    checkBoxWeight.Checked = false;
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd podczas sprawdzania czy możliwe jest obliczenie proporcji wagowej. Proszę spróbować ponownie.");
                return false;
            }
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToDatabaseWindow addToDatabaseForm = new AddToDatabaseWindow();
            addToDatabaseForm.Show();
        }

        //funkcja przygotowuje dane dla generatora PDF i wywołuje funkcję do wygenerowania pliku z obliczeniami.
        private void buttonGeneratePDF_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();

                foreach (DataGridViewColumn col in dataGridViewResult.Columns)
                {
                    data.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridViewResult.Rows)
                {
                    DataRow dRow = data.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    data.Rows.Add(dRow);
                }

                string title = "Proporcje produktów dodawanych dla produktu bazowego: " + labelResultBaseProduct.Text + "\n";
                if (radioButtonWholeCapacity.Checked) title += radioButtonWholeCapacity.Text;
                else title += radioButtonBaseCapacity.Text;
                title += "\n" + labelCapacity.Text + ": " + numericUpDownCapacity.Value.ToString();
                if (checkBoxWeight.Checked) title += checkBoxWeight.Text + ": " + numericUpDownWeight.Value.ToString();

                PDFGenerator.Generate(data, title);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy generowaniu pliku PDF z proporcjami produktów. Proszę spróbować ponownie.");
            }
        }

        private void deleteAddedRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFromDatabaseWindow deleteFromDatabase = new DeleteFromDatabaseWindow();
            deleteFromDatabase.Show();
        }

        private void checkBoxWeight_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWeight.Enabled = checkBoxWeight.Checked;
            if (checkBoxWeight.Checked == false) numericUpDownWeight.Value = 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy chcesz wyjść?", "VarnishMixApp", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = null;
            numericUpDownCapacity.Value = 0;
            numericUpDownWeight.Value = 0;
        }

        private void dataGridViewThinners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void dataGridViewHardeners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void dataGridViewBaseProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dataGridViewBaseProducts.SelectedRows.Count == 0)
            {
                buttonMakeCalculations.Enabled = false;
                dataGridViewThinners.DataSource = null;
                dataGridViewHardeners.DataSource = null;
                dataGridViewOptionals.DataSource = null;
            }
            else buttonMakeCalculations.Enabled = true;
        }

        private void dataGridViewOptionals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }
    }
}
