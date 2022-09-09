namespace HotelReception.DataStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyReservationTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservation", "StayDurationPerDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservation", "StayDurationPerDay", c => c.Int(nullable: false));
        }
    }
}
