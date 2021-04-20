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
    public partial class DeleteFromDatabaseWindow : Form
    {
        public DeleteFromDatabaseWindow()
        {
            InitializeComponent();
        }


        private void DeleteFromDatabase_Load(object sender, EventArgs e)
        {
            comboBoxBaseProducts.DataSource = Enum.GetValues(typeof(BaseProductTypes));
            comboBoxBaseProductsSelected.DataSource = Enum.GetValues(typeof(BaseProductTypes));
        }

        private void comboBoxBaseProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewBaseProductsWithRelated.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBoxBaseProducts.SelectedItem);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabeli. Proszę spróbować ponownie");
            }
        }

        private void buttonDeleteBaseProductWithRelated_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    var result = MessageBox.Show("Czy na pewno chcesz usunąć ten produkt bazowy i powiązane z nim produkty dodadtkowe?", "pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var baseProduct = db.BaseProducts.Where(bp => bp.BaseProductId == Convert.ToInt32(dataGridViewBaseProductsWithRelated.CurrentRow.Cells[0].Value)).First();
                        ProductProportionList productProportions = new ProductProportionList();
                        productProportions.AddRange(db.ProductPropotions.Where(pp => pp.BaseProduct.BaseProductId == Convert.ToInt32(dataGridViewBaseProductsWithRelated.CurrentRow.Cells[0].Value)).ToList());
                        AdditionalProduct additionalProduct = new AdditionalProduct();

                        foreach (ProductProportion product in productProportions)
                        {
                            db.Remove(product);
                            additionalProduct = db.AdditionalProducts.Where(ap => ap.AdditionalProductId == product.AdditionalProduct.AdditionalProductId).First();
                            db.Remove(additionalProduct);
                        }
                        db.Remove(baseProduct);

                        db.SaveChanges();
                        dataGridViewBaseProductsWithRelated.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBoxBaseProducts.SelectedItem);
                        MessageBox.Show("Usunięto");

                        MainWindow mainWindow = (MainWindow)Application.OpenForms[0];
                        mainWindow.PrepareBaseProduct();
                        mainWindow.PrepareAdditionalProducts();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania produktu. Spróbuj ponownie\n");
            }
        }



        private void comboBoxBaseProductsSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewBaseProducts.DataSource = db.GetBaseProductsInsertedByUser((BaseProductTypes)comboBoxBaseProducts.SelectedItem);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabeli. Proszę spróbować ponownie");
            }
        }

        private void dataGridViewBaseProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int baseproductidvalue = Convert.ToInt32(dataGridViewBaseProducts.CurrentRow.Cells[0].Value);

                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewAdditional.DataSource = db.GetAdditional(baseproductidvalue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabeli. Proszę spróbować ponownie");
            }
        }

        private void buttonDeleteSelectedAdditional_Click(object sender, EventArgs e)
        {
            try
            {
                int baseproductidvalue = Convert.ToInt32(dataGridViewBaseProducts.CurrentRow.Cells[0].Value);
                
                var result = MessageBox.Show("Czy na pewno chcesz usunąć ten produkt dodatkowy?", "pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (DatabaseObjectContext db = new DatabaseObjectContext())
                    {
                        ProductProportion productProportion = new ProductProportion();
                        AdditionalProduct additionalProduct = new AdditionalProduct();

                        foreach (DataGridViewRow dataGridViewRow in dataGridViewAdditional.SelectedRows)
                        {
                            productProportion = db.ProductPropotions.Where(pp => pp.AdditionalProduct.AdditionalProductId == Convert.ToInt32(dataGridViewRow.Cells[0].Value)).First();
                            additionalProduct = db.AdditionalProducts.Where(ap => ap.AdditionalProductId == Convert.ToInt32(dataGridViewRow.Cells[0].Value)).First();

                            db.RemoveRange(productProportion, additionalProduct);

                        }
                        db.SaveChanges();
                        dataGridViewAdditional.DataSource = db.GetAdditional(baseproductidvalue);

                        MessageBox.Show("Usunięto");

                        MainWindow mainWindow = (MainWindow)Application.OpenForms[0];
                        mainWindow.PrepareBaseProduct();
                        mainWindow.PrepareAdditionalProducts();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania produktu. Spróbuj ponownie");
            }
        }

        private void dataGridViewBaseProductsWithRelated_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void dataGridViewBaseProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void dataGridViewAdditional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }
    }
}
