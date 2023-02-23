using PetBreeders.Domain.Common;

namespace PetBreeders.Domain.Entities;

public class Pet : AuditableEntity
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
    public DateTime BirthDate { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public int BreedingId { get; set; }
    public Breeding Breeding { get; set; }
}