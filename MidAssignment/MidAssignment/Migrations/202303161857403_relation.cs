namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantEmployees",
                c => new
                    {
                        Restaurant_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Restaurant_Id, t.Employee_Id })
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Restaurant_Id)
                .Index(t => t.Employee_Id);
            
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurantEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.RestaurantEmployees", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.RestaurantEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.RestaurantEmployees", new[] { "Restaurant_Id" });
            AlterColumn("dbo.Restaurants", "Location", c => c.String());
            DropTable("dbo.RestaurantEmployees");
        }
    }
}
