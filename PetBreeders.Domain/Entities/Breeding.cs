using PetBreeders.Domain.Common;

namespace PetBreeders.Domain.Entities;

public class 
    Breeding : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public ICollection<Pet> Pets { get; set; }
    public ICollection<Certificate> Certificates { get; set; }
    public Address Address { get; set; }
}
