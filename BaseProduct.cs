using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "Lakier bezbarwny")]
        ClearVarnish = 2,    
        [Display(Name = "Lakier akrylowy")]
        AcrylicVarnish = 3,
        [Display(Name = "Podkład akrylowy")]
        AcrylicUnderlay = 4,
        [Display(Name = "Pozostałe")]
        Other = 5
    }

    public class BaseProduct
    {
        public int BaseProductId { get; set; }
        public string BaseProductName { get; set; }
        public BaseProductTypes BaseProductType { get; set; }
        public int InsertedByUser { get; set; }
        public virtual List<ProductProportion> ProductProportions { get; set; }


        public override string ToString()
        {
            return BaseProductName + " - " + BaseProductType.ToString();
        }
    }
}
