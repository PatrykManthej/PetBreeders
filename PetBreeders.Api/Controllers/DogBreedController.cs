using Microsoft.AspNetCore.Mvc;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreeds;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models;

namespace PetBreeders.Api.Controllers;

[Microsoft.AspNetCore.Components.Route("api/dogbreeds")]
public class DogBreedController : BaseController
{
    [HttpGet("breedId")]
    public async Task<ActionResult<DogBreedDetailVm>> GetBreedDetail(int breedId)
    {
        var vm = await Mediator.Send(new GetDogBreedQuery { DogBreedId = breedId});
        return vm;
    }
    [HttpGet("breed")]
    public async Task<ActionResult<DogBreedsVm>> GetBreeds(string breed)
    {
        var vm = await Mediator.Send(new GetDogBreedsQuery { BreedName = breed });
        return vm;
    }
}
