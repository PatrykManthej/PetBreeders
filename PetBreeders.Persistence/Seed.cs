using Microsoft.EntityFrameworkCore;
using PetBreeders.Domain.Entities;

namespace PetBreeders.Persistence;

public static class Seed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().HasData(
            new Pet { Id = 1, Type = "Dog", Breed = "Golden Retriever", BirthDate = DateTime.Now, Color = "Creamy", Description = "Confident, friendly", ImageUrl = string.Empty, BreedingId = 1, Created = DateTime.Now, StatusId = 1 },
            new Pet { Id = 2, Type = "Dog", Breed = "Samoyed", BirthDate = DateTime.Now, Color = "White", Description = "Confident, brave", ImageUrl = string.Empty, BreedingId = 2, Created = DateTime.Now, StatusId = 1 }
            );

        modelBuilder.Entity<Breeding>().HasData(
            new Breeding { Id = 1, Name = "RoyalGoldens", Description = "Proven breeding", ImageUrl = string.Empty, Phone = "123456789", Email = "RoyalGoldens@petbreeders.com", Created = DateTime.Now, StatusId = 1 },
            new Breeding { Id = 2, Name = "SnowySamoyeds", Description = "Proven breeding", ImageUrl = string.Empty, Phone = "111222333", Email = "SnowySamoyeds@petbreeders.com", Created = DateTime.Now, StatusId = 1 }
            );

        modelBuilder.Entity<Address>().HasData(
            new Address { Id = 1, City = "Warsaw", Street = "Mickiewicza", HouseNumber = "42", FlatNumber = "1", ZipCode = "11-214", BreedingId = 1, Created = DateTime.Now, StatusId = 1 },
            new Address { Id = 2, City = "Cracow", Street = "Brzozowa", HouseNumber = "115", FlatNumber = "8", ZipCode = "45-124", BreedingId = 2, Created = DateTime.Now, StatusId = 1 }
            );

        modelBuilder.Entity<Certificate>().HasData(
            new Certificate { Id = 1, Name = "ZKwP", Description = "Związek Kynologiczny w Polsce", ReceivedDate = DateTime.Now, BreedingId = 1, Created = DateTime.Now, StatusId = 1 },
            new Certificate { Id = 2, Name = "ZKwP", Description = "Związek Kynologiczny w Polsce", ReceivedDate = DateTime.Now, BreedingId = 2, Created = DateTime.Now, StatusId = 1 }
            );
    }
}
