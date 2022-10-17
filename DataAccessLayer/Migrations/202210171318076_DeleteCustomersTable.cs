namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCustomersTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategorySurname = c.String(),
                        CategoryCity = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
    }
}
