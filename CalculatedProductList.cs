using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public class CalculatedProductList : List<CalculatedProduct>
    {

        public static CalculatedProductList MakeCalculationWithBaseCapacity(ProductProportionList productProportions, decimal capacity, decimal weightcapacity, bool isweightproportionpossible)
        {

            CalculatedProductList calculatedProducts = new CalculatedProductList();
            using (DatabaseObjectContext db = new DatabaseObjectContext())
            {
                if (isweightproportionpossible == true)
                {
                    foreach (ProductProportion productProportion in productProportions)
                    {
                        CalculatedProduct calculatedProduct = new CalculatedProduct(db.GetAdditionalProduct(productProportion.AdditionalProduct.AdditionalProductId), null, null);
                        if (productProportion.DivisionProportion == null && productProportion.PercentProportion == null)
                        {
                            calculatedProduct.capacityCalculation = 0;
                        }
                        else if (productProportion.DivisionProportion == null && productProportion.PercentProportion != null) calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, capacity);
                        else calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.DivisionProportion, capacity);
                        calculatedProduct.WeightProportion((decimal)productProportion.WeightProportion, weightcapacity);

                        calculatedProducts.Add(calculatedProduct);
                    }
                }
                else
                {
                    foreach (ProductProportion productProportion in productProportions)
                    {
                        CalculatedProduct calculatedProduct = new CalculatedProduct(db.GetAdditionalProduct(productProportion.AdditionalProduct.AdditionalProductId), null, null);
                        if (productProportion.DivisionProportion == null && productProportion.PercentProportion == null)
                        {
                            calculatedProduct.capacityCalculation = 0;
                        }
                        else if(productProportion.DivisionProportion == null && productProportion.PercentProportion != null) calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.PercentProportion, capacity);
                        else calculatedProduct.DivisionOrPercentProportion((decimal)productProportion.DivisionProportion, capacity);
                        calculatedProducts.Add(calculatedProduct);
                    }
                }
            }
            return calculatedProducts;
        }

        public static CalculatedProductList MakeCalculationWithWholeCapacity(ProductProportionList productProportions, decimal wholecapacity, decimal wholeweightcapacity, bool isweightproportionpossible)
        {
            //tu trzeba ogarnąć
            decimal basewithproportions = 1;
            decimal weightwithproportions = 1;
            if (isweightproportionpossible == true)
            {
                foreach (ProductProportion productProportion in productProportions)
                {
                    if (productProportion.PercentProportion != null)
                    {
                        if (productProportion.DivisionProportion != null) basewithproportions += (decimal)productProportion.DivisionProportion;
                        else basewithproportions += (decimal)productProportion.PercentProportion;
                    }
                    weightwithproportions += ((decimal)productProportion.WeightProportion / 100);

                }
            }
            else
            {
                foreach (ProductProportion productProportion in productProportions)
                {
                    if (productProportion.PercentProportion != null)
                    {
                        if (productProportion.DivisionProportion != null) basewithproportions += (decimal)productProportion.DivisionProportion;
                        else basewithproportions += (decimal)productProportion.PercentProportion;
                    }
                }
            }
            decimal basecapacity = wholecapacity / basewithproportions;
            decimal weightcapacity = wholeweightcapacity / weightwithproportions;
            return MakeCalculationWithBaseCapacity(productProportions, basecapacity, weightcapacity, isweightproportionpossible);
        }
    }
}
