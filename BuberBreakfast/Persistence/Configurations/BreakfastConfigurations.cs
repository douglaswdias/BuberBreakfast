using BuberBreakfast.Models;
using Microsoft.EntityFrameworkCore;

namespace BuberBreakfast.Persistence.Configurations;

public class BreakfastConfigurations : IEntityTypeConfiguration<Breakfast>
{
  public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Breakfast> builder)
  {
    builder.HasKey(b => b.Id);
    
    builder.Property(b => b.Name)
      .HasMaxLength(Breakfast.MaxNameLength);

    builder.Property(b => b.Description)
      .HasMaxLength(Breakfast.MaxDescriptionLength);

    builder.Property(b => b.Savory)
      .HasConversion(
        v => string.Join(',', v),
        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
      );

      builder.Property(b => b.Sweet)
      .HasConversion(
        v => string.Join(',', v),
        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
      );
  }
}