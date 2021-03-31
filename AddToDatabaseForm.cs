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
    public partial class AddToDatabaseForm : Form
    {
        public AddToDatabaseForm()
        {
            InitializeComponent();
        }

        private void AddToDatabaseForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(BaseProductTypes));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Enabled = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    if (checkBox1.Checked == true || checkBox2.Checked == true || (checkBox1.Checked == true && checkBox2.Checked == true))
                    {
                        BaseProduct baseProduct = new BaseProduct { BaseProductId = db.GetLastBaseProductID(), BaseProductName = textBox1.Text, baseProductType = (BaseProductTypes)comboBox1.SelectedItem };


                        if (checkBox1.Checked)
                        {
                            AdditionalProduct additionalProductHardener = new AdditionalProduct { AdditionalProductId = db.GetLastAdditionalProductID(), AdditionalProductName = textBox2.Text, additionalProductType = AdditionalProductTypes.Hardener };
                            ProductProportion hardenerProportion = new ProductProportion {ProductProportionId = db.GetLastProductProportionID(), AdditionalProduct = additionalProductHardener, BaseProduct = baseProduct, IsConstrainted = 1, WeightProportion = numericUpDown2.Value, PercentProportion = numericUpDown1.Value/100, DivisionProportion = (1/numericUpDown3.Value)};
                        }
                        if (checkBox2.Checked)
                        {

                        }
                    }
                }
            }
        }
    }
}
