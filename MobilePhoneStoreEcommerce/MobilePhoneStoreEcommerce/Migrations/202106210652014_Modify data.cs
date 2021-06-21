namespace MobilePhoneStoreEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifydata : DbMigration
    {
        public override void Up()
        {
            Sql("update Accounts set Status = 1;");
        }
        
        public override void Down()
        {
        }
    }
}
