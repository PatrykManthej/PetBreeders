using Microsoft.EntityFrameworkCore;
using PetBreeders.Domain.Entities;

namespace PetBreeders.Application.Common.Interfaces;
public interface IPetBreedersDbContext
{
     DbSet<Breeding> Breedings { get; set; }
     DbSet<Address> Addresses { get; set; }
     DbSet<Certificate> Certificates { get; set; }
     DbSet<Pet> Pets { get; set; }

     Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}
