using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarnishMixApp
{
    public class ProductProportionList : List<ProductProportion>
    {
        //za dużo przekazuje w tej funkcji, do poprawy
        public static ProductProportionList GetProductProportions(int baseproductidvalue, DataGridView dataGridView2, DataGridView dataGridView3, DataGridView dataGridView4)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                bool isanythinner = db.GetAnyThinner(baseproductidvalue);
                bool isanyhardener = db.GetAnyHardener(baseproductidvalue);
                bool isanyoptional = db.GetAnyOptional(baseproductidvalue);

                ProductProportionList productProportions = new ProductProportionList();
                if (isanythinner == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value)));
                if (isanyhardener == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value)));
                if (isanyoptional == true)
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value)));
                    }
                }
                return productProportions;
            }

        }
    }
}


