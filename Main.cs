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
            }

            //listBox1.Items.Add(String.Format(listboxformat, dataGridView1.CurrentRow.Cells[1].Value,"","",""));
        }
    }
}
