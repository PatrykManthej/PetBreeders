namespace PetBreeders.Application.Common.Interfaces;

public interface IDogApiClient
{
    Task<string> GetBreeds(string searchFilter, CancellationToken cancellationToken);
    Task<string> GetBreedDetail(int breedId, CancellationToken cancellationToken);
    Task<string> GetBreedImage(string breedImageId, CancellationToken cancellationToken);
}