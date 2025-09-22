using AutoMapper;

using ELibrary.Core.DTOs;
using ELibrary.Web.Areas.Admin.Models.ResourceViewModels;
using ELibrary.Web.Models;

namespace ELibrary.Web.Automapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<ResourceDto, ResourceViewModel>();

            CreateMap<ResourceAddViewModel, ResourceDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id ?? Guid.NewGuid().ToString()))
                .ReverseMap();
        }
    }
}
