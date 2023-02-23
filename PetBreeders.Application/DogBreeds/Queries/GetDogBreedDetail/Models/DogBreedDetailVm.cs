using Newtonsoft.Json;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;

public class DogBreedDetailVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LifeSpan { get; set; }
    public string Character { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string ImageUrl { get; set; }
}