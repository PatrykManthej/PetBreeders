using AutoMapper;
using MediatR;
using Newtonsoft.Json;
using PetBreeders.Application.Common.Interfaces;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail;

public class GetDogBreedQueryHandler : IRequestHandler<GetDogBreedQuery, DogBreedDetailVm>
{
    private readonly IDogApiClient _dogApiClient;
    private readonly IMapper _mapper;

    public GetDogBreedQueryHandler(IDogApiClient dogApiClient, IMapper mapper)
    {
        _dogApiClient = dogApiClient;
        _mapper = mapper;
    }

    public async Task<DogBreedDetailVm> Handle(GetDogBreedQuery request, CancellationToken cancellationToken)
    {
        var response = await _dogApiClient.GetBreedDetail(request.DogBreedId, cancellationToken);
        var deserializedDogBreed = JsonConvert.DeserializeObject<DogBreedDetailDeserialized>(response);

        var dogBreedVm = _mapper.Map<DogBreedDetailVm>(deserializedDogBreed);

        var dogBreedImage = await _dogApiClient.GetBreedImage(deserializedDogBreed.ImageId, cancellationToken);
        var dogBreedImageUrlWrapper = JsonConvert.DeserializeObject<BreedImageUrlWrapper>(dogBreedImage);

        dogBreedVm.ImageUrl = dogBreedImageUrlWrapper.Url;

        return dogBreedVm;
    }
}