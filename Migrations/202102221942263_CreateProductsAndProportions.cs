namespace VarnishMixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProductsAndProportions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalProducts",
                c => new
                    {
                        AdditionalProductId = c.Int(nullable: false, identity: true),
                        AdditionalProductName = c.String(),
                        LayerThickness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Layer = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DryOffTime = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AdditionalProductId);
            
            CreateTable(
                "dbo.ProductProportions",
                c => new
                    {
                        ProductProportionId = c.Int(nullable: false, identity: true),
                        BaseProductId = c.Int(nullable: false),
                        DivisionProportion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PercentProportion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WeightProportion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalProduct_AdditionalProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductProportionId)
                .ForeignKey("dbo.AdditionalProducts", t => t.AdditionalProduct_AdditionalProductId)
                .ForeignKey("dbo.BaseProducts", t => t.BaseProductId, cascadeDelete: true)
                .Index(t => t.BaseProductId)
                .Index(t => t.AdditionalProduct_AdditionalProductId);
            
            CreateTable(
                "dbo.BaseProducts",
                c => new
                    {
                        BaseProductId = c.Int(nullable: false, identity: true),
                        BaseProductName = c.String(),
                        LayerThickness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Layer = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DryOffTime = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BaseProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductProportions", "BaseProductId", "dbo.BaseProducts");
            DropForeignKey("dbo.ProductProportions", "AdditionalProduct_AdditionalProductId", "dbo.AdditionalProducts");
            DropIndex("dbo.ProductProportions", new[] { "AdditionalProduct_AdditionalProductId" });
            DropIndex("dbo.ProductProportions", new[] { "BaseProductId" });
            DropTable("dbo.BaseProducts");
            DropTable("dbo.ProductProportions");
            DropTable("dbo.AdditionalProducts");
        }
    }
}
