using Newtonsoft.Json;

namespace PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;

public class DogBreedDetailDeserialized
{
    public int Id { get; set; }
    public string Name { get; set; }

    [JsonProperty("life_span")]
    public string LifeSpan { get; set; }

    public string Temperament { get; set; }

    public Weight Weight { get; set; }

    public Height Height { get; set; }
    [JsonProperty("reference_image_id")]
    public string ImageId { get; set; }
}

public class Weight
{
    public string Imperial { get; set; }
    public string Metric { get; set; }
}

public class Height
{
    public string Imperial { get; set; }
    public string Metric { get; set; }
}