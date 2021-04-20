using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace VarnishMixApp
{
    public partial class AddToDatabaseWindow : Form
    {
        public AddToDatabaseWindow()
        {
            InitializeComponent();
        }

        private void AddToDatabaseForm_Load(object sender, EventArgs e)
        {
            comboBoxBaseProductType.DataSource = Enum.GetValues(typeof(BaseProductTypes));
            comboBoxBaseProduct.DataSource = Enum.GetValues(typeof(BaseProductTypes));
        }

        public void IsAddBaseAndRequiredPossible()
        {
            if (textBoxBaseProductName.Text != "")
            {
                if (checkBoxThinner.Checked && checkBoxHardener.Checked)
                {
                    if (textBoxThinnerName.Text != "" && textBoxHardenerName.Text != "") buttonAddToDatabaseBaseAndRequired.Enabled = true;
                    else buttonAddToDatabaseBaseAndRequired.Enabled = false;
                }
                else if (checkBoxThinner.Checked)
                {
                    if (textBoxThinnerName.Text != "") buttonAddToDatabaseBaseAndRequired.Enabled = true;
                    else buttonAddToDatabaseBaseAndRequired.Enabled = false;
                }
                else if (checkBoxHardener.Checked)
                {
                    if (textBoxHardenerName.Text != "") buttonAddToDatabaseBaseAndRequired.Enabled = true;
                    else buttonAddToDatabaseBaseAndRequired.Enabled = false;
                }
                else buttonAddToDatabaseBaseAndRequired.Enabled = false;
            }
            else buttonAddToDatabaseBaseAndRequired.Enabled = false;
        }

        private void checkBoxBaseHardener_CheckedChanged(object sender, EventArgs e)
        {
            panelHardener.Enabled = checkBoxHardener.Checked;

            IsAddBaseAndRequiredPossible();
        }

        private void checkBoxBaseThinner_CheckedChanged(object sender, EventArgs e)
        {
            panelThinner.Enabled = checkBoxThinner.Checked;

            IsAddBaseAndRequiredPossible(); 
        }

        private void buttonAddToDatabaseBaseAndRequired_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    BaseProduct baseProduct = new BaseProduct
                    {
                        BaseProductId = db.GetLastBaseProductID()+1,
                        BaseProductName = textBoxBaseProductName.Text,
                        BaseProductType = (BaseProductTypes)comboBoxBaseProductType.SelectedItem,
                        InsertedByUser = 1
                    };

                    if ((checkBoxHardener.Checked == true && checkBoxThinner.Checked == true) || (checkBoxHardener.Checked == true || checkBoxThinner.Checked == true))
                    {
                        db.Add(baseProduct);
                        db.SaveChanges();
                        if (checkBoxHardener.Checked == true)
                        {
                            if (CheckIfAnyProprtionIsNull(numericUpDownPercentProportionHardener.Value, numericUpDownDivisionProportionHardener.Value) == true)
                            {
                                AdditionalProduct additionalProductHardener = new AdditionalProduct
                                {
                                    AdditionalProductId = db.GetLastAdditionalProductID()+1,
                                    AdditionalProductName = textBoxHardenerName.Text,
                                    additionalProductType = AdditionalProductTypes.Hardener,
                                    InsertedByUser = 1
                                };
                                ProductProportion hardenerProportion = new ProductProportion
                                {
                                    ProductProportionId = db.GetLastProductProportionID()+1,
                                    AdditionalProduct = additionalProductHardener,
                                    BaseProduct = baseProduct,
                                    IsConstrainted = 1,
                                    WeightProportion = CheckIfProportionIsNull(numericUpDownWeightProportionHardener.Value),
                                    PercentProportion = CheckIfProportionIsNull(numericUpDownPercentProportionHardener.Value) / 100,
                                    DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDownDivisionProportionHardener.Value))
                                };
                                db.Add(additionalProductHardener);
                                db.Add(hardenerProportion);
                                db.SaveChanges();
                            }
                            else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla utwardzacza");
                        }
                        if (checkBoxThinner.Checked == true)
                        {
                            if (CheckIfAnyProprtionIsNull(numericUpDownPercentProportionThinner.Value, numericUpDownDivisionProportionThinner.Value) == true)
                            {
                                AdditionalProduct additionalProductThinner = new AdditionalProduct
                                {
                                    AdditionalProductId = db.GetLastAdditionalProductID()+1,
                                    AdditionalProductName = textBoxThinnerName.Text,
                                    additionalProductType = AdditionalProductTypes.Thinner,
                                    InsertedByUser = 1
                                };
                                ProductProportion thinnerProportion = new ProductProportion
                                {
                                    ProductProportionId = db.GetLastProductProportionID()+1,
                                    AdditionalProduct = additionalProductThinner,
                                    BaseProduct = baseProduct,
                                    IsConstrainted = 1,
                                    WeightProportion = CheckIfProportionIsNull(numericUpDownWeightProportionThinner.Value),
                                    PercentProportion = CheckIfProportionIsNull(numericUpDownPercentProportionThinner.Value) / 100,
                                    DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDownDivisionProportionThinner.Value))
                                };
                                db.Add(additionalProductThinner);
                                db.Add(thinnerProportion);
                                db.SaveChanges();
                            }
                            else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla rozcieńczalnika");

                        }
                        MessageBox.Show("Dodano produkty do bazy");

                        MainWindow mainWindow = (MainWindow)Application.OpenForms[0];
                        mainWindow.PrepareBaseProduct();
                        mainWindow.PrepareAdditionalProducts();
                    }
                    else MessageBox.Show("Proszę wybrać conajmniej jeden produkt dodatkowy do dodania");
                }


            }
            
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("Wystąpił błąd podczas dodawania produktów. Proszę spróbować ponownie");
            }

        }

        public decimal? CheckIfProportionIsNull(decimal value)
        {
            if (value <= 0) return null;
            else return value;
        }

        public bool CheckIfAnyProprtionIsNull(decimal percentprop, decimal divisionprop)
        {

            if (percentprop == 0 && divisionprop == 0) return false;
            else return true;
        }

        private void textBoxBaseProductName_TextChanged(object sender, EventArgs e)
        {
            if ((checkBoxHardener.Checked == true || checkBoxThinner.Checked == true) || (checkBoxHardener.Checked == true && checkBoxThinner.Checked == true))
            {
                if (textBoxBaseProductName.Text != "") buttonAddToDatabaseBaseAndRequired.Enabled = true;
                else buttonAddToDatabaseBaseAndRequired.Enabled = false;
            }
        }

        private void comboBoxBaseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    dataGridViewBaseProductSelect.DataSource = db.GetBaseProducts((BaseProductTypes)comboBoxBaseProduct.SelectedItem);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd przy próbie załadowania danych do tabeli. Proszę spróbować ponownie");
            }
        }

        

        private void buttonAddAdditionalProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    BaseProduct baseProduct = db.BaseProducts.Where(bp => bp.BaseProductId == Convert.ToInt32(dataGridViewBaseProductSelect.CurrentRow.Cells[0].Value)).First();
                    if (CheckIfAnyProprtionIsNull(numericUpDownWeightProportionAdditional.Value, numericUpDownDivisionAdditional.Value) == true)
                    {
                        AdditionalProduct additionalProduct = new AdditionalProduct
                        {
                            AdditionalProductId = db.GetLastAdditionalProductID() + 1,
                            AdditionalProductName = textBoxAdditionalProductName.Text,
                            additionalProductType = GetProperAdditionalProductType(),
                            InsertedByUser = 1
                        };
                        ProductProportion additionalProductProportion = new ProductProportion
                        {
                            ProductProportionId = db.GetLastProductProportionID() + 1,
                            AdditionalProduct = additionalProduct,
                            BaseProduct = baseProduct,
                            IsConstrainted = CheckIfIsConstrainted(),
                            WeightProportion = CheckIfProportionIsNull(numericUpDownWeightProportionAdditional.Value),
                            PercentProportion = CheckIfProportionIsNull(numericUpDownPercentProportionAdditional.Value) / 100,
                            DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDownDivisionAdditional.Value))
                        };
                        db.AddRange(additionalProduct, additionalProductProportion);
                        var a = db.SaveChanges().ToString();


                        MessageBox.Show("Dodano produkt do bazy");

                        MainWindow mainWindow = (MainWindow)Application.OpenForms[0];
                        mainWindow.PrepareBaseProduct();
                        mainWindow.PrepareAdditionalProducts();
                        
                    }
                    else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla produktu");

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("Wystąpił błąd podczas dodawania produktu. Proszę spróbować ponownie" );
            }
        }

        public AdditionalProductTypes GetProperAdditionalProductType()
        {
            if (radioButtonRequired.Checked == true)
            {
                if (radioButtonHardener.Checked == true) return AdditionalProductTypes.Hardener;
                else return AdditionalProductTypes.Thinner;
            }
            return AdditionalProductTypes.Other;
        }

        public int CheckIfIsConstrainted()
        {
            if (GetProperAdditionalProductType() == AdditionalProductTypes.Other) return 0;
            return 1;
        }

        private void radioButtonRequired_CheckedChanged(object sender, EventArgs e)
        {
            panelHardenerOrThinner.Enabled = radioButtonRequired.Checked;
        }

        private void textBoxAdditionalProductName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdditionalProductName.Text == "") buttonAddAdditionalProduct.Enabled = false;
            else buttonAddAdditionalProduct.Enabled = true;
        }

        private void dataGridViewBaseProductSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void textBoxHardenerName_TextChanged(object sender, EventArgs e)
        {
            IsAddBaseAndRequiredPossible();
        }

        private void textBoxThinnerName_TextChanged(object sender, EventArgs e)
        {
            IsAddBaseAndRequiredPossible();
        }
    }
}
