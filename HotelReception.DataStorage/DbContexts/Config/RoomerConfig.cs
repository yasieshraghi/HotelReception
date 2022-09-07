using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class RoomerConfig : EntityTypeConfiguration<RoomerModel>
    {
        public RoomerConfig()
        {
            ToTable("Roomer", "dbo");
            HasKey(c => c.Id);

            HasRequired(a => a.CareTaker)
                .WithMany(c => c.RoomerCareTakers)
                .HasForeignKey(b => b.CareTakerId)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Partner)
                .WithMany(c => c.RoomerPartners)
                .HasForeignKey(b => b.CustomerPartnerId)
                .WillCascadeOnDelete(false);
        }
    }
}
