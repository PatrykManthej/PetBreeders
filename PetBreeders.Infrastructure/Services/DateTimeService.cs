using PetBreeders.Application.Common.Interfaces;

namespace PetBreeders.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
