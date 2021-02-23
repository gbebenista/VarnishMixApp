using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public enum BaseProductTypes
    {
        Underlay,
        [Display(Name = "Base Varnish")]
        BaseVarnish,
        [Display(Name = "Acrylic Varnish")]
        AcrylicVarnish
    }

    public class BaseProduct
    {
        public int BaseProductId { get; set; }
        public string BaseProductName { get; set; }
        public BaseProductTypes baseProductType { get; set; }
        public decimal LayerThickness { get; set; }
        public decimal Layer { get; set; }
        public decimal DryOffTime { get; set; }

        public virtual List<ProductProportion> ProductProportions { get; set; }
    }
}
