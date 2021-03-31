using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public class CalculatedProductList : List<CalculatedProduct>
    {

        public static CalculatedProductList MakeCalculationWithBaseCapacity(ProductProportionList productProportions, decimal basecapcity, bool ischeckboxchecked)
        {
            //dać to do calculatedproductlist? przekazywać checkbox1.Checked, zrobić do dwóch miejsc po przecinku
            CalculatedProductList calculatedProducts = new CalculatedProductList();
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                foreach (ProductProportion productProportion in productProportions)
                {
                    CalculatedProduct calculatedProduct = new CalculatedProduct(db.GetAdditionalProduct(productProportion.AdditionalProduct.AdditionalProductId), null, null);
                    if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, basecapcity);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion == null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.DivisionProportion, basecapcity);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, basecapcity);
                    }

                    if (ischeckboxchecked == true)
                    {
                        calculatedProduct.WeightProportion((decimal)productProportion.WeightProportion, basecapcity);
                    }
                    calculatedProducts.Add(calculatedProduct);
                }
            }
            return calculatedProducts;
        }

        public static CalculatedProductList MakeCalculationWithWholeCapacity(ProductProportionList productProportions, decimal wholecapacity, bool ischeckboxchecked)
        {
            decimal basewithproportions = 1;
            foreach (ProductProportion productProportion in productProportions)
            {
                if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null) basewithproportions += (decimal)productProportion.PercentProportion;
                else if (productProportion.DivisionProportion != null && productProportion.PercentProportion == null) basewithproportions += (decimal)productProportion.DivisionProportion;
                else if (productProportion.DivisionProportion != null && productProportion.PercentProportion != null) basewithproportions += (decimal)productProportion.DivisionProportion;
                else if (productProportion.DivisionProportion == null && productProportion.PercentProportion == null) basewithproportions += ((decimal)productProportion.WeightProportion / 100);

            }
            decimal basecapacity = wholecapacity / basewithproportions;
            return MakeCalculationWithBaseCapacity(productProportions, basecapacity, ischeckboxchecked);
        }
    }
}
