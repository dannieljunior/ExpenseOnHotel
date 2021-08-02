using ExpenseOnHotel.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseOnHotel.Infrastructure.EntityConfigurations
{
    internal class HotelFacilityEntityConfiguration : IEntityTypeConfiguration<HotelFacility>
    {
        public void Configure(EntityTypeBuilder<HotelFacility> builder)
        {
            builder.ToTable("HotelFacility");
            builder.HasKey(hotelFacility => hotelFacility.Id);

            builder.Property(hotelFacility => hotelFacility.CreatedDate)
                 .IsRequired();
            
            builder.Property(hotelFacility => hotelFacility.HotelId)
                 .IsRequired();
            
            builder.Property(hotelFacility => hotelFacility.FacilityId)
                 .IsRequired();

            builder
                .HasOne(hotelFacility => hotelFacility.Hotel)
                .WithMany(hotel => hotel.Facilities)
                .HasForeignKey(hotelfacility => hotelfacility.HotelId);  
            
            builder
                .HasOne(hotelFacility => hotelFacility.Facility)
                .WithMany(facility => facility.Facilities)
                .HasForeignKey(hotelfacility => hotelfacility.FacilityId);

            builder
                .HasIndex(hotelFacility => new {hotelFacility.HotelId , hotelFacility.FacilityId}).IsUnique();
            
            builder.Property(hotel => hotel.CreatedDate)
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            
        }
    }
}