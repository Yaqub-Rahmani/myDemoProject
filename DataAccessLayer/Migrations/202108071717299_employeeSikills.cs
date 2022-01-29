namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeeSikills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeUsers", "employeeSkills", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeUsers", "employeeSkills");
        }
    }
}
