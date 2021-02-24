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
            comboBox1.DataSource = Enum.GetNames(typeof(BaseProductTypes));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseObjectContext db = new DatabaseObjectContext();
            dataGridView1.DataSource = db.GetBaseProducts();
        }
    }
}
