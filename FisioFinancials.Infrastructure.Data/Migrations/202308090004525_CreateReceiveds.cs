namespace FisioFinancials.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateReceiveds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Receiveds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientName = c.String(nullable: false),
                        Value = c.Single(nullable: false),
                        City = c.String(nullable: false),
                        Local = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Receiveds");
        }
    }
}
