using AutoMapper;

using ELibrary.Core.DTOs;
using ELibrary.Web.Models;

namespace ELibrary.Web.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //E.g. CreateMap<Resource, ResourceServiceModel>();
            CreateMap<ResourceViewModel, ResourceDto>();
        }
    }
}
