namespace VarnishMixApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdditionalProducts", "additionalProductType", c => c.Int(nullable: false));
            AddColumn("dbo.BaseProducts", "baseProductType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaseProducts", "baseProductType");
            DropColumn("dbo.AdditionalProducts", "additionalProductType");
        }
    }
}
