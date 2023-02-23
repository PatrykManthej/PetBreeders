using MediatR;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreeds;

public class GetDogBreedsQuery : IRequest<DogBreedsVm>
{
    public string BreedName { get; set; }
}
