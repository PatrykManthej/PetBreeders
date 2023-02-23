using Newtonsoft.Json;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models;

public class DogBreedDeserialized
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonProperty("reference_image_id")]
    public string ImageId { get; set; }
    public string ImageUrl { get; set; }
}