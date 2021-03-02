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
        String listboxformat = "{0, -10}{1, -10}{2, -10}{3, -10}";

        public Main()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(BaseProductTypes));

            listBox1.Items.Add(String.Format(listboxformat, "Produkt dodawany", "Proporcja", "Proporcja", "Propocja"));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseProductTypes baseproducttype;
            Enum.TryParse<BaseProductTypes>(comboBox1.SelectedValue.ToString(), out baseproducttype);

            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView1.DataSource = db.GetBaseProducts(baseproducttype);
            }

            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                dataGridView4.DataSource = null;
                label4.Text ="";
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void dataGridView1_SelectedRow(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            int baseproductidvalue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            label4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView3.DataSource = db.GetAdditionalConstraintedThinner(baseproductidvalue);
                dataGridView4.DataSource = db.GetAdditionalConstraintedHardener(baseproductidvalue);
            }


            //listBox1.Items.Add(String.Format(listboxformat, dataGridView1.CurrentRow.Cells[1].Value,"","",""));
        }
    }
}
