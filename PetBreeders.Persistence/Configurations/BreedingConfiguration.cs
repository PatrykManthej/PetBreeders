using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetBreeders.Domain.Entities;

namespace PetBreeders.Persistence.Configurations;

public class BreedingConfiguration : IEntityTypeConfiguration<Breeding>
{
    public void Configure(EntityTypeBuilder<Breeding> builder)
    {
        builder.Property(b => b.Name).IsRequired();
    }
}