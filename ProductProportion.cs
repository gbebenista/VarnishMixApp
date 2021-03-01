using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarnishMixApp
{
    public class ProductProportion
    {
        public int ProductProportionId { get; set; }

        public int BaseProductId { get; set; }
        public virtual BaseProduct BaseProduct { get; set; }

        public virtual AdditionalProduct AdditionalProduct { get; set; }
        public int IsConstrainted { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? DivisionProportion { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PercentProportion { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? WeightProportion { get; set; }
    }
}
