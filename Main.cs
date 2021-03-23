using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarnishMixApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(BaseProductTypes));
            //comboBox1.SelectedItem = null;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView1.DataSource = db.GetBaseProducts((BaseProductTypes)comboBox1.SelectedItem);
            }

            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView4.DataSource = null;
                button1.Enabled = false;
                panel2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                panel2.Enabled = true;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView1_SelectedRow(object sender, EventArgs e)
        {
            int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView3.DataSource = db.GetAdditionalConstraintedThinner(baseproductidvalue);
                dataGridView4.DataSource = db.GetAdditionalConstraintedHardener(baseproductidvalue);
                dataGridView2.DataSource = db.GetAdditionalOther(baseproductidvalue);
                dataGridView2.ClearSelection();
            }
        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //może przenieść do funkcji i return true/false, jak true to robi kolejne funkcje
            int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                bool isanythinner = db.GetAnyThinner(baseproductidvalue);
                bool isanyhardener = db.GetAnyHardener(baseproductidvalue);
                bool isanyoptional = db.GetAnyOptional(baseproductidvalue);


                if (isanythinner == false && isanyhardener == false) MessageBox.Show("Bazowy produkt nie posiada żadnego produktu wymaganego do zmieszania");
                else if (isanythinner == true && dataGridView3.SelectedRows.Count == 0) MessageBox.Show("Nie zaznaczono rozcieńczalnika, pomimo że jest wymagany i znajduje się na liście");
                else if (isanyhardener == true && dataGridView4.SelectedRows.Count == 0) MessageBox.Show("Nie zaznaczono utwardzacza, pomimo że jest wymagany i znajduje się na liście");
                else
                {
                    //i to też do funkcji
                    ProductProportionList productProportions = new ProductProportionList();
                    if (isanythinner == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value)));
                    if (isanyhardener == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value)));
                    if (isanyoptional == true)
                    {
                        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                        {
                            productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value)));
                        }
                    }

                    if (radioButton1.Enabled == true) dataGridView5.DataSource = MakeCalculationWithBaseCapacity(productProportions);
                    else if (radioButton2.Enabled == true) dataGridView5.DataSource = MakeCalculationWithBaseCapacity(productProportions);
                }

            }
        }
        

        public CalculatedProductList MakeCalculationWithBaseCapacity(ProductProportionList productProportions)
        {
            //dać to do calculatedproductlist?
            CalculatedProductList calculatedProducts = new CalculatedProductList();
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                foreach (ProductProportion productProportion in productProportions)
                {
                    CalculatedProduct calculatedProduct = new CalculatedProduct(db.GetAdditionalProduct(productProportion.AdditionalProduct.AdditionalProductId), null, null);
                    if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, numericUpDown1.Value);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion == null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.DivisionProportion, numericUpDown1.Value);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, numericUpDown1.Value);
                    }

                    if (checkBox1.Checked == true)
                    {
                        calculatedProduct.WeightProportion((decimal)productProportion.WeightProportion, numericUpDown1.Value);
                    }
                    calculatedProducts.Add(calculatedProduct);
                }
            }
            return calculatedProducts;
        }

        public CalculatedProductList MakeCalculationWithWholeCapacity(ProductProportionList productProportions)
        {
            CalculatedProductList calculatedProducts = new CalculatedProductList();
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
            }
            return calculatedProducts;
        }


                private void dataGridViewCheckWeightProportion(object sender, EventArgs e)
        {
            checkBox1.Enabled = IsWeightProportionPossible();
        }

        public bool IsWeightProportionPossible()
        {
            decimal? thinner = 0;
            decimal? hardener = 0;
            decimal? optional = 0;

            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                if (dataGridView1.Rows.Count == 0) return false;

                int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (db.GetAnyThinner(baseproductidvalue) == true)
                {
                    thinner = db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
                }

                if (db.GetAnyHardener(baseproductidvalue) == true)
                {
                    hardener = db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value));
                }

                if (db.GetAnyOptional(baseproductidvalue) == true)
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        if (db.GetWeightProportion(baseproductidvalue, Convert.ToInt32(row.Cells[0].Value)) == null) optional = null;
                    }
                }

            }

            if (thinner != null && hardener != null && optional != null) return true;
            else return false;
        }

    }
}
