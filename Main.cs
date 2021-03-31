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

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(BaseProductTypes));

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                if (Validators.CheckIsAnyAdditionalProducts(baseproductidvalue, dataGridView3.Rows.Count, dataGridView4.Rows.Count) == true)
                {
                    ProductProportionList productProportions = ProductProportionList.GetProductProportions(baseproductidvalue, dataGridView1, dataGridView3, dataGridView4);

                    if (radioButton1.Checked == true) dataGridView5.DataSource = CalculatedProductList.MakeCalculationWithBaseCapacity(productProportions, numericUpDown1.Value, checkBox1.Checked);
                    else dataGridView5.DataSource = CalculatedProductList.MakeCalculationWithWholeCapacity(productProportions, numericUpDown1.Value, checkBox1.Checked);

                    button2.Enabled = true;
                }
            }


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

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToDatabaseForm addToDatabaseForm = new AddToDatabaseForm();
            addToDatabaseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to jest tak brzydkie że aż mnie oczy bolą

            DataTable data = new DataTable();

            foreach (DataGridViewColumn col in dataGridView5.Columns)
            {
                data.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                DataRow dRow = data.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                data.Rows.Add(dRow);
            }

            PDFGenerator.Generate(data);
        }
    }
}
