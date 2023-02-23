using AutoMapper;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreedDetail.Models;
using PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models;
using DogBreedDeserialized = PetBreeders.Application.DogBreeds.Queries.GetDogBreeds.Models.DogBreedDeserialized;

namespace PetBreeders.Application.Common.MappingProfiles;

public class DogBreedProfile : Profile
{
    public DogBreedProfile()
    {
        CreateMap<DogBreedDeserialized, DogBreedDto>();
            //.ForMember(
            //    dst => dst.Character,
            //    opt =>
            //        opt.MapFrom(src => src.Temperament))
            //.ForMember(dst=>dst.Height,
            //    opt => 
            //        opt.MapFrom(src=>src.Height.Metric))
            //.ForMember(dst => dst.Weight,
            //    opt =>
            //        opt.MapFrom(src => src.Weight.Metric));
        
        CreateMap<DogBreedDetailDeserialized, DogBreedDetailVm>()
            .ForMember(
                dst => dst.Character,
                opt =>
                    opt.MapFrom(src => src.Temperament))
            .ForMember(dst => dst.Height,
                opt =>
                    opt.MapFrom(src => src.Height.Metric))
            .ForMember(dst => dst.Weight,
                opt =>
                    opt.MapFrom(src => src.Weight.Metric));
    }
}
