using Microsoft.EntityFrameworkCore;

namespace PetBreeders.Persistence;

public class PetBreedersDbContextFactory : DesignTimeDBContextFactoryBase<PetBreedersDbContext>
{
    protected override PetBreedersDbContext CreateNewInstance(DbContextOptions<PetBreedersDbContext> options)
    {
        return new PetBreedersDbContext(options);
    }
}
