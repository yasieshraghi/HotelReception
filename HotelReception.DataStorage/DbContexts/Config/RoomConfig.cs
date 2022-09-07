using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class RoomConfig : EntityTypeConfiguration<RoomModel>
    {
        public RoomConfig()
        {
            ToTable("Room", "dbo");
            HasKey(c => c.Id);

            HasMany(a => a.RoomReservations)
                .WithRequired(b => b.Room)
                .HasForeignKey(b => b.RoomId);
        }
    }
}
