namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Time", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "Time");
        }
    }
}
