using System.Data.Entity.ModelConfiguration;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class RoomConfig : EntityTypeConfiguration<RoomModel>
    {
        public RoomConfig()
        {
            ToTable("Room", "dbo");
            HasKey(c => c.Id);

            HasMany(a => a.Reservations)
                .WithRequired(b => b.Room)
                .HasForeignKey(b => b.RoomId);
        }
    }
}
