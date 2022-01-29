namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saveMageDatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeUsers", "SavedateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeUsers", "SavedateTime");
        }
    }
}
