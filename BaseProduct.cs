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
        [Display(Name = "Podkład reaktywny")]
        ReactUnderlay = 0,
        [Display(Name = "Podkład epoksydowy")]
        EpoxidUnderlay = 1,
        [Display(Name = "Lakier bazowy")]
        BaseVarnish = 2,
        [Display(Name = "Lakier akrylowy")]
        AcrylicVarnish = 3
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
