using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .WithMany(c => c.RoomReservations)
                .HasForeignKey(b => b.RoomId)
                .WillCascadeOnDelete(false);
        }
    }
}
