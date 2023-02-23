using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PetBreeders.Application.Common.Interfaces;
using PetBreeders.Domain.Common;
using PetBreeders.Domain.Entities;

namespace PetBreeders.Persistence;

public class PetBreedersDbContext : DbContext, IPetBreedersDbContext
{
    private readonly IDateTime _dateTime;
    public PetBreedersDbContext(DbContextOptions<PetBreedersDbContext> options) : base(options)
    {
    }
    public PetBreedersDbContext(DbContextOptions<PetBreedersDbContext> options, IDateTime dateTime) : base(options)
    {
        _dateTime = dateTime;
    }
    
    public DbSet<Breeding> Breedings { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Pet> Pets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.SeedData();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = string.Empty;
                    entry.Entity.Created = _dateTime.Now;
                    entry.Entity.StatusId = 1;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    break;
                case EntityState.Deleted:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    entry.Entity.Inactivated = _dateTime.Now;
                    entry.Entity.InactivatedBy = string.Empty;
                    entry.Entity.StatusId = 0;
                    entry.State = EntityState.Modified;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
