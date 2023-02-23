using MediatR;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail;

public class GetDogBreedQuery : IRequest<DogBreedDetailVm>
{
    public int DogBreedId { get; set; }
}
