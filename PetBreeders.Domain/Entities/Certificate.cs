using PetBreeders.Domain.Common;

namespace PetBreeders.Domain.Entities;

public class Certificate : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ReceivedDate { get; set; }

    public int BreedingId { get; set; }
    public Breeding Breeding { get; set; }
}