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
        public static ProductProportionList GetProductProportions(int baseproductidvalue, DataGridViewSelectedRowCollection dataGridViewOptionalSelectedRows, int? thinnerID, int? hardenerID)
        {
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                ProductProportionList productProportions = new ProductProportionList();
                if (db.GetAnyThinner(baseproductidvalue) == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, (int)thinnerID));
                if (db.GetAnyHardener(baseproductidvalue) == true) productProportions.Add(db.GetProductProportion(baseproductidvalue, (int)hardenerID));
                if (db.GetAnyOptional(baseproductidvalue) == true)
                {
                    foreach (DataGridViewRow row in dataGridViewOptionalSelectedRows)
                    {
                        productProportions.Add(db.GetProductProportion(baseproductidvalue, Convert.ToInt32(row.Cells[0].Value)));
                    }
                }
                return productProportions;
            }

        }
    }
}


