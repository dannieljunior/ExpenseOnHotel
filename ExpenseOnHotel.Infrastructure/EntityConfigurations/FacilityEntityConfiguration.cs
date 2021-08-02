using ExpenseOnHotel.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseOnHotel.Infrastructure.EntityConfigurations
{
    internal class FacilityEntityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.ToTable("Facility");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .IsRequired();
            
            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);;
        }
    }
}