using AutoMapper;

using ELibrary.Core.DTOs;
using ELibrary.Web.Models;

namespace ELibrary.Web.Automapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            //E.g. CreateMap<Resource, ResourceServiceModel>();
            CreateMap<ResourceDto, ResourceViewModel>();
        }
    }
}
