namespace EqptInv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Num = c.String(),
                        Make = c.String(),
                        Model = c.String(),
                        Hours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Machines");
        }
    }
}
