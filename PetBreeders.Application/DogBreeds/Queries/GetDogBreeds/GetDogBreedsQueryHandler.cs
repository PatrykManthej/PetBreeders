using AutoMapper;
using MediatR;
using Newtonsoft.Json;
using PetBreeders.Application.Common.Interfaces;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreeds;

public class GetDogBreedsQueryHandler : IRequestHandler<GetDogBreedsQuery, DogBreedsVm>
{
    private readonly IDogApiClient _dogApiClient;
    private readonly IMapper _mapper;

    public GetDogBreedsQueryHandler(IDogApiClient dogApiClient, IMapper mapper)
    {
        _dogApiClient = dogApiClient;
        _mapper = mapper;
    }

    public async Task<DogBreedsVm> Handle(GetDogBreedsQuery request, CancellationToken cancellationToken)
    {
        var response = await _dogApiClient.GetBreeds(request.BreedName, cancellationToken);

        var deserializedDogBreeds = JsonConvert.DeserializeObject<List<DogBreedDeserialized>>(response);

        foreach (var breed in deserializedDogBreeds)
        {
            if(String.IsNullOrEmpty(breed.ImageId))
                continue;

            var breedImage = await _dogApiClient.GetBreedImage(breed.ImageId, cancellationToken);
            var breedImageUrlWrapper = JsonConvert.DeserializeObject<BreedImageUrlWrapper>(breedImage);

            breed.ImageUrl = breedImageUrlWrapper.Url;
        }

        var dogBreedsDto = _mapper.Map<IEnumerable<DogBreedDto>>(deserializedDogBreeds);

        return new DogBreedsVm {DogBreeds = dogBreedsDto };
    }
}
