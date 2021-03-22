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
        Thinner = 0,
        Hardener = 1,
        Other = 2
    }


    public class AdditionalProduct
    {
        public int AdditionalProductId { get; set; }
        public string AdditionalProductName { get; set; }
        public AdditionalProductTypes additionalProductType { get; set; }

        public virtual List<ProductProportion> ProductProportions { get; set; }

        
    }
}
