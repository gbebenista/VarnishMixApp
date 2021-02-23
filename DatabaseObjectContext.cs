using System.Data.Entity;
using System.Linq;

namespace VarnishMixApp
{
    public class DatabaseObjectContext : DbContext
    {
        public DbSet<BaseProduct> BaseProducts { get; set; }
        public DbSet<AdditionalProduct> AdditionalProducts { get; set; }
        public DbSet<ProductProportion> ProductPropotions { get; set; }

        //public void GetBaseProducts()
        //{
        //    using (var context = new DatabaseObjectContext())
        //    {
               
        //    }
        //}




    }
}
