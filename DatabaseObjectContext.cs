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

       

        public List<BaseProduct> GetBaseProducts(BaseProductTypes type)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.BaseProducts.Where(bp => bp.baseProductType == type).OrderBy(a => a.BaseProductId).ToList();
            }
        }

        //public IQueryable<BaseProduct> GetBaseProducts(BaseProductTypes bptype)
        //{
        //    using (DatabaseObjectContext context = new DatabaseObjectContext())
        //    {
        //        return  context.BaseProducts.Where(bp => bp.baseProductType == bptype);
        //    }
        //}

        public List<AdditionalProduct> GetAdditionalConstraintedThinner(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {

                //return context.AdditionalProducts.Include(ap => ap.ProductProportions.Where(b => b.BaseProductId == id).Where(b => b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Thinner).ToList();
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(c => c.additionalProductType == AdditionalProductTypes.Thinner).ToList();


            }
        }

        public List<AdditionalProduct> GetAdditionalConstraintedHardener(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                //return context.AdditionalProducts.Include(ap => ap.ProductProportions.Where(b => b.BaseProductId == id).Where(b => b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Hardener).ToList();

                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(c => c.additionalProductType == AdditionalProductTypes.Hardener).ToList();
            }
        }

        public List<AdditionalProduct> GetAdditionalOther(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions.Where(b => b.BaseProductId == id).Where(b => b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Other).ToList();
            }
        }


    }
}
