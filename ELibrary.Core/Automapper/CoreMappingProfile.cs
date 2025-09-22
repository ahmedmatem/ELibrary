using AutoMapper;
using ELibrary.Core.DTOs;
using ELibrary.Infrastructure.Data.Models;

namespace ELibrary.Core.Automapper
{
    public class CoreMappingProfile : Profile
    {
        public CoreMappingProfile()
        {
            //E.g. CreateMap<Resource, ResourceServiceModel>();
            CreateMap<Resource, ResourceDto>().ReverseMap();
        }
    }
}
