namespace HotelReception.DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCustomerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerInfo", "FirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.CustomerInfo", "LastName", c => c.String(maxLength: 60));
            AlterColumn("dbo.CustomerInfo", "PhoneNumber", c => c.String(maxLength: 14));
            AlterColumn("dbo.CustomerInfo", "PassportNo", c => c.String(maxLength: 12));
            DropColumn("dbo.CustomerInfo", "HasCareTaker");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerInfo", "HasCareTaker", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CustomerInfo", "PassportNo", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerInfo", "PhoneNumber", c => c.String(maxLength: 30));
            AlterColumn("dbo.CustomerInfo", "LastName", c => c.String(maxLength: 150));
            AlterColumn("dbo.CustomerInfo", "FirstName", c => c.String(maxLength: 150));
        }
    }
}
