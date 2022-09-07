using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class CustomerInfoConfig : EntityTypeConfiguration<CustomerInfoModel>
    {
        public CustomerInfoConfig()
        {
            ToTable("CustomerInfo", "dbo");
            HasKey(c => c.Id);

            HasMany(a => a.CareTakerReservations)
                .WithRequired(b => b.CareTaker)
                .HasForeignKey(b => b.CareTakerId);


            HasMany(a => a.RoomerCareTakers)
                .WithRequired(b => b.CareTaker)
                .HasForeignKey(b => b.CareTakerId);

            HasMany(a => a.RoomerPartners)
                .WithRequired(b => b.Partner)
                .HasForeignKey(b => b.CustomerPartnerId);
        }
    }
}
