using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBreeders.Domain.Entities;

namespace PetBreeders.Persistence.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.Property(p => p.Type).IsRequired();
        builder.Property(p=>p.Breeding).IsRequired();

    }
}