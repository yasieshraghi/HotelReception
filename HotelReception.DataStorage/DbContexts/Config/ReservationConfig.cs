using System.Data.Entity.ModelConfiguration;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class ReservationConfig : EntityTypeConfiguration<ReservationModel>
    {
        public ReservationConfig()
        {
            ToTable("Reservation", "dbo");
            HasKey(c => c.Id);

            HasRequired(a => a.Room)
                .WithMany(c => c.Reservations)
                .HasForeignKey(b => b.RoomId)
                .WillCascadeOnDelete(false);
        }
    }
}
