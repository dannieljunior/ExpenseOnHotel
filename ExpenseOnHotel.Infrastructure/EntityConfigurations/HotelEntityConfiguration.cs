using ExpenseOnHotel.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseOnHotel.Infrastructure.EntityConfigurations
{
    internal class HotelEntityConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotel");
            builder.HasKey(hotel => hotel.Id);

            builder.Property(hotel => hotel.Name)
                .IsRequired();
            
            builder.Property(hotel => hotel.Description)
                .IsRequired();
            
            builder.Property(hotel => hotel.Rating)
                .IsRequired();
            
            builder.Property(hotel => hotel.Address)
                .IsRequired();
            
            builder.Property(hotel => hotel.AddressDistrict)
                .IsRequired();
            
            builder.Property(hotel => hotel.AddressPostalCode)
                .IsRequired();
            
            builder.Property(hotel => hotel.AddressCity)
                .IsRequired();


            builder.Property(hotel => hotel.AddressState)
                .IsRequired();

            builder.Property(hotel => hotel.CreatedDate)
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        }
    }
}