using Microsoft.EntityFrameworkCore;
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
    public partial class DeleteFromDatabase : Form
    {
        public DeleteFromDatabase()
        {
            InitializeComponent();
        }


        private void DeleteFromDatabase_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(BaseProductTypes));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView1.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    var baseProduct = db.BaseProducts.Where(bp => bp.BaseProductId == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).First();
                    var result = MessageBox.Show("Czy na pewno chcesz usunąć ten produkt bazowy i powiązane z nim produkty dodadtkowe?", "pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db.Remove(baseProduct);
                        db.SaveChanges();
                        dataGridView1.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBox1.SelectedItem);
                    }
                    
                }
            }
            catch (DbUpdateException dbex)
            {
               // MessageBox.Show()
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd. Spróbuj ponownie\n");
            }
        }
    }
}
