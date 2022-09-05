using System.Data.Entity;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts
{
    public class HotelReceptionContext : DbContext
    {
        //todo:DbContext
        public readonly string ConnectionString = "";

         
        public HotelReceptionContext(string connectionString) :base(connectionString)
        {
            
        }
        public DbSet<CustomerInfoModel> CustomerInfo { get; set; }
        public DbSet<ReservationModel> Reservation { get; set; }
        public DbSet<RoomerModel> Roomer { get; set; }
        public DbSet<RoomModel> Room { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerInfoModel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ReservationModel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<RoomerModel>()
                .HasKey(c => c.Id);
                //.HasRequired(c=>c.CareTakerId).h(c=>c.);

             modelBuilder.Entity<RoomModel>()
                .HasKey(c => c.Id);

        }
    }
}