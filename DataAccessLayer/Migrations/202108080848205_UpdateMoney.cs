namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoney : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeUsers", "employeeMoneyAz", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeUsers", "employeeMoneyAz");
        }
    }
}
