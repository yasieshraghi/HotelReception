namespace HotelReception.DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roomer", "CareTakerId", "dbo.CustomerInfo");
            DropForeignKey("dbo.Roomer", "CustomerPartnerId", "dbo.CustomerInfo");
            DropIndex("dbo.Reservation", new[] { "CareTakerId" });
            DropIndex("dbo.Roomer", new[] { "CareTakerId" });
            DropIndex("dbo.Roomer", new[] { "CustomerPartnerId" });
            RenameColumn(table: "dbo.Reservation", name: "CareTakerId", newName: "CustomerInfoModel_Id");
            AlterColumn("dbo.Reservation", "CustomerInfoModel_Id", c => c.Int());
            CreateIndex("dbo.Reservation", "CustomerInfoModel_Id");
            DropTable("dbo.Roomer");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roomer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CareTakerId = c.Int(nullable: false),
                        CustomerPartnerId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.Reservation", new[] { "CustomerInfoModel_Id" });
            AlterColumn("dbo.Reservation", "CustomerInfoModel_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reservation", name: "CustomerInfoModel_Id", newName: "CareTakerId");
            CreateIndex("dbo.Roomer", "CustomerPartnerId");
            CreateIndex("dbo.Roomer", "CareTakerId");
            CreateIndex("dbo.Reservation", "CareTakerId");
            AddForeignKey("dbo.Roomer", "CustomerPartnerId", "dbo.CustomerInfo", "Id");
            AddForeignKey("dbo.Roomer", "CareTakerId", "dbo.CustomerInfo", "Id");
        }
    }
}
