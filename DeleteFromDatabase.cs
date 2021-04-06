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
            comboBox2.DataSource = Enum.GetValues(typeof(BaseProductTypes));
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
                    ProductProportionList productProportions = new ProductProportionList();
                    productProportions.AddRange(db.ProductPropotions.Where(pp => pp.BaseProduct.BaseProductId == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).ToList());
                    AdditionalProduct additionalProduct = new AdditionalProduct();
                    var result = MessageBox.Show("Czy na pewno chcesz usunąć ten produkt bazowy i powiązane z nim produkty dodadtkowe?", "pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //usuwane baseProduct i  AdditionalProduct
                    if (result == DialogResult.Yes)
                    {

                        foreach (ProductProportion product in productProportions)
                        {
                            db.Remove(product);
                            additionalProduct = db.AdditionalProducts.Where(ap => ap.AdditionalProductId == product.AdditionalProduct.AdditionalProductId).First();
                            db.Remove(additionalProduct);
                        }
                        db.Remove(baseProduct);

                        db.SaveChanges();
                        dataGridView1.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBox1.SelectedItem);
                        MessageBox.Show("Usunięto");
                    }

                }
            }
            catch (DbUpdateException dbex)
            {
                MessageBox.Show(dbex?.InnerException?.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd. Spróbuj ponownie\n");
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView2.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBox1.SelectedItem);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int baseproductidvalue = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView3.DataSource = db.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == baseproductidvalue)).Where(ap => ap.InsertedByUser == 1).OrderBy(ap => ap.AdditionalProductId).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductProportion productProportion = new ProductProportion();
                AdditionalProduct additionalProduct = new AdditionalProduct();
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    foreach (DataGridViewRow dataGridViewRow in dataGridView3.SelectedRows)
                    {
                        productProportion = db.ProductPropotions.Where(pp => pp.AdditionalProduct.AdditionalProductId == Convert.ToInt32(dataGridViewRow.Cells[0].Value)).First();
                        additionalProduct = db.AdditionalProducts.Where(ap => ap.AdditionalProductId == Convert.ToInt32(dataGridViewRow.Cells[0].Value)).First();

                        db.RemoveRange(productProportion, additionalProduct);

                    }
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException dbex)
            {
                MessageBox.Show(dbex?.InnerException?.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd. Spróbuj ponownie");
            }
        }
    }
}
