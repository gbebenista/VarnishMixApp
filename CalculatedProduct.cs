using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public class CalculatedProduct 
    {
        public AdditionalProduct additionalProduct { get; set; }
        public decimal? weightCalculation { get; set; }
        public decimal? capacityCalculation { get; set; }


        public decimal DivisionOrPercentProportion(decimal proportion, decimal baseproductsize)
        {
            capacityCalculation = baseproductsize * proportion;
            return (decimal)capacityCalculation;
        }

        public decimal WeightProportion(decimal proportion, decimal baseproductweight)
        {
            weightCalculation = (baseproductweight * proportion) / 100;
            return (decimal)weightCalculation;
        }

        public CalculatedProduct(AdditionalProduct additional, decimal? weight, decimal? capacity)
        {
            additionalProduct = additional;
            weightCalculation = weight;
            capacityCalculation = capacity;
        }

    }

}
