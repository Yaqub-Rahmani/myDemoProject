namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class companyAdderss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "companyAddress", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "companyAddress");
        }
    }
}
