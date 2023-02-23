using PetBreeders.Domain.Common;

namespace PetBreeders.Domain.Entities;

public class Address : AuditableEntity
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string FlatNumber { get; set; }
    public string ZipCode { get; set; }

    public int BreedingId { get; set; }
    public Breeding Breeding { get; set; }
}