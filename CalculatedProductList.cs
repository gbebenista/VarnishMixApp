using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public class CalculatedProductList : List<CalculatedProduct>
    {

        public static CalculatedProductList MakeCalculationWithBaseCapacity(ProductProportionList productProportions, decimal capacity, decimal weightcapacity, bool ischeckboxchecked)
        {

            CalculatedProductList calculatedProducts = new CalculatedProductList();
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                foreach (ProductProportion productProportion in productProportions)
                {
                    CalculatedProduct calculatedProduct = new CalculatedProduct(db.GetAdditionalProduct(productProportion.AdditionalProduct.AdditionalProductId), null, null);
                    if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, capacity);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion == null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.DivisionProportion, capacity);
                    }
                    else if (productProportion.DivisionProportion != null && productProportion.PercentProportion != null)
                    {
                        calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, capacity);
                    }

                    if (ischeckboxchecked == true)
                    {
                        calculatedProduct.WeightProportion((decimal)productProportion.WeightProportion, weightcapacity);
                    }
                    calculatedProducts.Add(calculatedProduct);
                }
            }
            return calculatedProducts;
        }

        public static CalculatedProductList MakeCalculationWithWholeCapacity(ProductProportionList productProportions, decimal wholecapacity, decimal wholeweightcapacity, bool ischeckboxchecked)
        {
            //tu trzeba ogarnąć
            decimal basewithproportions = 1;
            decimal weightwithproportions = 1;
            foreach (ProductProportion productProportion in productProportions)
            {
                if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null) basewithproportions += (decimal)productProportion.PercentProportion;
                else if (productProportion.DivisionProportion != null && productProportion.PercentProportion == null) basewithproportions += (decimal)productProportion.DivisionProportion;
                else if (productProportion.DivisionProportion != null && productProportion.PercentProportion != null) basewithproportions += (decimal)productProportion.DivisionProportion;
                else if (productProportion.DivisionProportion == null && productProportion.PercentProportion == null) weightwithproportions += ((decimal)productProportion.WeightProportion / 100);

            }
            decimal basecapacity = wholecapacity / basewithproportions;
            decimal weightcapacity = wholeweightcapacity / weightwithproportions;
            return MakeCalculationWithBaseCapacity(productProportions, basecapacity, weightcapacity, ischeckboxchecked);
        }
    }
}
