namespace HotelReception.DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 150),
                        LastName = c.String(maxLength: 150),
                        Gender = c.Byte(nullable: false),
                        PhoneNumber = c.String(maxLength: 30),
                        EmailAddress = c.String(maxLength: 70),
                        PassportNo = c.String(maxLength: 20),
                        Age = c.Int(nullable: false),
                        HasCareTaker = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CustomerInfoId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        StayDurationPerDay = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Room", t => t.RoomId)
                .ForeignKey("dbo.CustomerInfo", t => t.CustomerInfoId)
                .Index(t => t.CustomerInfoId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Byte(nullable: false),
                        PricePerDay = c.Long(nullable: false),
                        Floor = c.Byte(nullable: false),
                        Number = c.Int(nullable: false),
                        HasWindow = c.Boolean(nullable: false),
                        BedNumbers = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservation", "CustomerInfoId", "dbo.CustomerInfo");
            DropForeignKey("dbo.Reservation", "RoomId", "dbo.Room");
            DropIndex("dbo.Reservation", new[] { "RoomId" });
            DropIndex("dbo.Reservation", new[] { "CustomerInfoId" });
            DropTable("dbo.Room");
            DropTable("dbo.Reservation");
            DropTable("dbo.CustomerInfo");
        }
    }
}
