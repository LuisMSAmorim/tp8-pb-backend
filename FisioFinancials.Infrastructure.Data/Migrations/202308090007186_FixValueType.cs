namespace FisioFinancials.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixValueType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Receiveds", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Receiveds", "Value", c => c.Single(nullable: false));
        }
    }
}
