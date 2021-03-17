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
            //Enum.TryParse<BaseProductTypes>(comboBox1.SelectedValue.ToString(), out baseproducttype);


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
            int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                bool isanythinner = db.GetAnyThinner(baseproductidvalue);
                bool isanyhardener = db.GetAnyHardener(baseproductidvalue);

                if (isanythinner == false && isanyhardener == false) MessageBox.Show("Bazowy produkt nie posiada żadnego produktu wymaganego do zmieszania");
                else if (isanythinner == true && dataGridView3.SelectedRows.Count == 0) MessageBox.Show("Nie zaznaczono rozcieńczalnika, pomimo że jest wymagany i znajduje się na liście");
                else if (isanyhardener == true && dataGridView4.SelectedRows.Count == 0) MessageBox.Show("Nie zaznaczono utwardzacza, pomimo że jest wymagany i znajduje się na liście");
                else
                {
                    
                }

            }
        }
    }
}
