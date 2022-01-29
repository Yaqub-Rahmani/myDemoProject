namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeCvUlr : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeUsers", "employeeCVPhoto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeUsers", "employeeCVPhoto", c => c.String(maxLength: 250));
        }
    }
}
