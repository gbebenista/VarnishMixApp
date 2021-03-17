using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    class ProductCalculation
    {

        //private AdditionalProduct additionalProduct { get; }
        //private BaseProduct baseProduct { get; }
        //private ProductProportion productProportion { get; }

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
            foreach(decimal product in products)
            {
                baseproduct += product;
            }
            return baseproduct;
        }



    }
}
