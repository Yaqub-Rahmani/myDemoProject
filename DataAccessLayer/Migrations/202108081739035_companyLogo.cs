namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class companyLogo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "companyLogoPhoto", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "companyLogoPhoto");
        }
    }
}
