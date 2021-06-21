namespace MobilePhoneStoreEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDomain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "NumberError", c => c.Int(nullable: false));
            AddColumn("dbo.Accounts", "Status", c => c.Boolean(nullable: false));
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "NumError", c => c.Int(nullable: false));
            DropColumn("dbo.Accounts", "Status");
            DropColumn("dbo.Accounts", "NumberError");
        }
    }
}
