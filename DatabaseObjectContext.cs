using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VarnishMixApp
{
    public class DatabaseObjectContext : DbContext
    {
        public DbSet<BaseProduct> BaseProducts { get; set; }
        public DbSet<AdditionalProduct> AdditionalProducts { get; set; }
        public DbSet<ProductProportion> ProductPropotions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Moje Pliki\Studia\Seminarium Licencjackie\program na prace\VarnishMixApp\VarnishMixApp\bin\Debug\Database.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        public List<BaseProduct> GetBaseProducts()
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.BaseProducts.OrderBy(a => a.BaseProductId).ToList();
            }
        }

        //public IQueryable<BaseProduct> GetBaseProducts(BaseProductTypes bptype)
        //{
        //    using (DatabaseObjectContext context = new DatabaseObjectContext())
        //    {
        //        return  context.BaseProducts.Where(bp => bp.baseProductType == bptype);
        //    }
        //}

        public IQueryable<AdditionalProduct> GetAdditionalConstraintedThinner(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions.Where(b => b.BaseProductId == id).Where(b => b.IsConstrainted == true)).Where(c => c.additionalProductType == AdditionalProductTypes.Thinner);
            }
        }

        public IQueryable<AdditionalProduct> GetAdditionalConstraintedHardener(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions.Where(b => b.BaseProductId == id).Where(b => b.IsConstrainted == true)).Where(c => c.additionalProductType == AdditionalProductTypes.Hardener);
            }
        }


    }
}
