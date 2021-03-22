using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    class CalculatedProduct : AdditionalProduct
    {
        private AdditionalProduct additionalproduct { get; set; }
        private decimal calculation { get; set; }


        public decimal DivisionOrPercentProportion(decimal proportion, int baseproductsize)
        {
            return baseproductsize * proportion;
        }

        public decimal WeightProportion(decimal proportion, decimal baseproductweight)
        {
            return (baseproductweight * proportion) / 100;
        }

        public decimal MixedProducts(decimal baseproduct, List<decimal> products)
        {
            foreach (decimal product in products)
            {
                baseproduct += product;
            }
            return baseproduct;
        }
    }

}
