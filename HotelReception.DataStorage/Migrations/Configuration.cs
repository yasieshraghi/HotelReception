namespace HotelReception.DataStorage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContexts.HotelReceptionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbContexts.HotelReceptionContext context)
        {
            context.Room.AddRange(MyDataSeed.DataSeedRooms());
            context.SaveChanges();
        }
    }
}
