using System.Data.Entity.ModelConfiguration;
using HotelReception.DataStorage.Entities;

namespace HotelReception.DataStorage.DbContexts.Config
{
    public class CustomerInfoConfig : EntityTypeConfiguration<CustomerInfoModel>
    {
        public CustomerInfoConfig()
        {
            ToTable("CustomerInfo", "dbo");
            HasKey(c => c.Id);

            HasMany(a => a.Reservations)
                .WithRequired(b => b.CustomerInfo)
                .HasForeignKey(b => b.CustomerInfoId)
                .WillCascadeOnDelete(false);
        }
    }
}
