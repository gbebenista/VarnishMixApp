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
            //optionsBuilder.UseSqlite(@"Data Source=D:\Moje Pliki\Studia\Seminarium Licencjackie\program na prace\VarnishMixApp\VarnishMixApp\bin\Debug\Database.db", options =>
            optionsBuilder.UseSqlite(@"Data Source=Database.db", options =>
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

        public List<AdditionalProduct> GetAdditionalConstraintedThinner(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == id && b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Thinner).ToList();
            }
        }

        public List<AdditionalProduct> GetAdditionalConstraintedHardener(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == id && b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Hardener).ToList();
            }
        }

        public List<AdditionalProduct> GetAdditionalOther(int id)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == id && b.IsConstrainted == 0)).Where(c => c.additionalProductType == AdditionalProductTypes.Other).ToList();
            }
        }

        public decimal? GetDivisionProportion(int baseproductid, int additionalproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.ProductPropotions.FirstOrDefault(pp => pp.BaseProduct.BaseProductId == baseproductid && pp.AdditionalProduct.AdditionalProductId == additionalproductid).DivisionProportion;
            }
        }

        public decimal? GetPercentProportion(int baseproductid, int additionalproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.ProductPropotions.FirstOrDefault(pp => pp.BaseProduct.BaseProductId == baseproductid && pp.AdditionalProduct.AdditionalProductId == additionalproductid).PercentProportion;
            }
        }

        public decimal? GetWeightProportion(int baseproductid, int additionalproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.ProductPropotions.FirstOrDefault(pp => pp.BaseProduct.BaseProductId == baseproductid && pp.AdditionalProduct.AdditionalProductId == additionalproductid).WeightProportion;
            }
        }

        public ProductProportion GetProductProportion(int baseproductid, int additionalproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.ProductPropotions.Include(bp => bp.BaseProduct).Include(ap => ap.AdditionalProduct).Where(pp => pp.BaseProduct.BaseProductId == baseproductid && pp.AdditionalProduct.AdditionalProductId == additionalproductid).FirstOrDefault();
            }
        }


        public bool GetAnyThinner(int baseproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == baseproductid && b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Thinner).Any();
            }
        }


        public bool GetAnyHardener(int baseproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == baseproductid && b.IsConstrainted == 1)).Where(c => c.additionalProductType == AdditionalProductTypes.Hardener).Any();
            }
        }

        public bool GetAnyOptional(int baseproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Include(ap => ap.ProductProportions).Where(ap => ap.ProductProportions.Any(b => b.BaseProduct.BaseProductId == baseproductid && b.IsConstrainted == 0)).Where(c => c.additionalProductType == AdditionalProductTypes.Other).Any();
            }
        }

        public AdditionalProduct GetAdditionalProduct(int additionalproductid)
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.Where(ap => ap.AdditionalProductId == additionalproductid).First();
            }
        }

        public int GetLastBaseProductID()
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.BaseProducts.OrderByDescending(bp => bp.BaseProductId).FirstOrDefault().BaseProductId;
            }
        }

        public int GetLastAdditionalProductID()
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.AdditionalProducts.OrderByDescending(ap => ap.AdditionalProductId).FirstOrDefault().AdditionalProductId;
            }
        }

        public int GetLastProductProportionID()
        {
            using (DatabaseObjectContext context = new DatabaseObjectContext())
            {
                return context.ProductPropotions.OrderByDescending(pp => pp.ProductProportionId).FirstOrDefault().ProductProportionId;
            }
        }
    }
}
