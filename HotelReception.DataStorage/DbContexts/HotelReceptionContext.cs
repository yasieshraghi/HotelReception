using System.Data.Entity;
using HotelReception.DataStorage.DbContexts.Config;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts
{
    public class HotelReceptionContext : DbContext
    {
        static HotelReceptionContext()
        {
            Database.SetInitializer<HotelReceptionContext>(null);
        }
        public HotelReceptionContext() : base("HotelReception")
        {

        }

        public DbSet<CustomerInfoModel> CustomerInfo { get; set; }
        public DbSet<ReservationModel> Reservation { get; set; }
        public DbSet<RoomerModel> Roomer { get; set; }
        public DbSet<RoomModel> Room { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Configurations.Add(new CustomerInfoConfig());

            modelBuilder.Configurations.Add(new ReservationConfig());

            modelBuilder.Configurations.Add(new RoomerConfig());

            modelBuilder.Configurations.Add(new RoomConfig());


        }
    }
}