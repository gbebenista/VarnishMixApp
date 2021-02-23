using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public enum AdditionalProductTypes
    {
        //TODO: add additional product types
    }


    public class AdditionalProduct
    {
        public int AdditionalProductId { get; set; }
        public string AdditionalProductName { get; set; }
        public AdditionalProductTypes additionalProductType { get; set; }
        public decimal LayerThickness { get; set; }
        public decimal Layer { get; set; }
        public decimal DryOffTime { get; set; }

        public virtual List<ProductProportion> ProductProportions { get; set; }
    }
}
