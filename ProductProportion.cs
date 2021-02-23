using System;
using System.Collections.Generic;
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

        public decimal DivisionProportion { get; set; }
        public decimal PercentProportion { get; set; }
        public decimal WeightProportion { get; set; }
    }
}
