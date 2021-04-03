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
    public partial class AddToDatabaseForm : Form
    {
        public AddToDatabaseForm()
        {
            InitializeComponent();
        }

        private void AddToDatabaseForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(BaseProductTypes));
            comboBox2.DataSource = Enum.GetValues(typeof(BaseProductTypes));
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
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    BaseProduct baseProduct = new BaseProduct
                    {
                        BaseProductId = db.GetLastBaseProductID()+1,
                        BaseProductName = textBox1.Text,
                        BaseProductType = (BaseProductTypes)comboBox1.SelectedItem,
                        InsertedByUser = 1
                    };

                    if ((checkBox1.Checked == true && checkBox2.Checked == true) || (checkBox1.Checked == true || checkBox2.Checked == true))
                    {
                        db.Add(baseProduct);
                        db.SaveChanges();
                        if (checkBox1.Checked == true)
                        {
                            if (CheckIfAnyProprtionIsNull(numericUpDown1.Value, numericUpDown3.Value) == true)
                            {
                                AdditionalProduct additionalProductHardener = new AdditionalProduct
                                {
                                    AdditionalProductId = db.GetLastAdditionalProductID()+1,
                                    AdditionalProductName = textBox2.Text,
                                    additionalProductType = AdditionalProductTypes.Hardener,
                                    InsertedByUser = 1
                                };
                                ProductProportion hardenerProportion = new ProductProportion
                                {
                                    ProductProportionId = db.GetLastProductProportionID()+1,
                                    AdditionalProduct = additionalProductHardener,
                                    BaseProduct = baseProduct,
                                    IsConstrainted = 1,
                                    WeightProportion = CheckIfProportionIsNull(numericUpDown2.Value),
                                    PercentProportion = CheckIfProportionIsNull(numericUpDown1.Value) / 100,
                                    DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDown3.Value))
                                };
                                db.Add(additionalProductHardener);
                                db.Add(hardenerProportion);
                                db.SaveChanges();
                            }
                            else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla utwardzacza");
                        }
                        if (checkBox2.Checked == true)
                        {
                            if (CheckIfAnyProprtionIsNull(numericUpDown5.Value, numericUpDown7.Value) == true)
                            {
                                AdditionalProduct additionalProductThinner = new AdditionalProduct
                                {
                                    AdditionalProductId = db.GetLastAdditionalProductID()+1,
                                    AdditionalProductName = textBox3.Text,
                                    additionalProductType = AdditionalProductTypes.Thinner,
                                    InsertedByUser = 1
                                };
                                ProductProportion thinnerProportion = new ProductProportion
                                {
                                    ProductProportionId = db.GetLastProductProportionID()+1,
                                    AdditionalProduct = additionalProductThinner,
                                    BaseProduct = baseProduct,
                                    IsConstrainted = 1,
                                    WeightProportion = CheckIfProportionIsNull(numericUpDown6.Value),
                                    PercentProportion = CheckIfProportionIsNull(numericUpDown5.Value) / 100,
                                    DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDown7.Value))
                                };
                                db.Add(additionalProductThinner);
                                db.Add(thinnerProportion);
                                db.SaveChanges();
                            }
                            else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla rozcieńczalnika");

                        }
                        MessageBox.Show("Dodano produkty do bazy");
                    }
                    else MessageBox.Show("Proszę wybrać conajmniej jeden produkt dodatkowy do dodania");
                }


            }
            
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("Wystąpił błąd. Proszę spróbować ponownie");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                dataGridView1.DataSource = db.GetBaseProducts((BaseProductTypes)comboBox2.SelectedItem);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseObjectContext db = new DatabaseObjectContext())
                {
                    BaseProduct baseProduct = db.BaseProducts.Where(bp => bp.BaseProductId == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).First();
                    if (CheckIfAnyProprtionIsNull(numericUpDown8.Value, numericUpDownDivision.Value) == true)
                    {
                        AdditionalProduct additionalProduct = new AdditionalProduct
                        {
                            AdditionalProductId = db.GetLastAdditionalProductID() + 1,
                            AdditionalProductName = textBox4.Text,
                            additionalProductType = GetProperAdditionalProductType(),
                            InsertedByUser = 1
                        };
                        ProductProportion additionalProductProportion = new ProductProportion
                        {
                            ProductProportionId = db.GetLastProductProportionID() + 1,
                            AdditionalProduct = additionalProduct,
                            BaseProduct = baseProduct,
                            IsConstrainted = 1,
                            WeightProportion = CheckIfProportionIsNull(numericUpDown8.Value),
                            PercentProportion = CheckIfProportionIsNull(numericUpDown9.Value) / 100,
                            DivisionProportion = (1 / CheckIfProportionIsNull(numericUpDownDivision.Value))
                        };
                        db.AddRange(additionalProduct, additionalProductProportion);
                        var a = db.SaveChanges().ToString();


                        MessageBox.Show("Dodano produkt do bazy");
                    }
                    else MessageBox.Show("Prosze podać co najmniej jedną proporcję objętościową (ilorazową lub procentową) dla produktu");

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("Wystąpił błąd. Proszę spróbować ponownie" );
            }
        }

        public AdditionalProductTypes GetProperAdditionalProductType()
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton3.Checked == true) return AdditionalProductTypes.Hardener;
                else return AdditionalProductTypes.Thinner;
            }
            return AdditionalProductTypes.Other;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = radioButton1.Checked;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "") button2.Enabled = true;
            else button2.Enabled = false;
        }
    }
}
