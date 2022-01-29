namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrollMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminLars", "AdminRoll", c => c.String(maxLength: 2));
            AddColumn("dbo.AdminLars", "AdminAct", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminLars", "AdminAct");
            DropColumn("dbo.AdminLars", "AdminRoll");
        }
    }
}
