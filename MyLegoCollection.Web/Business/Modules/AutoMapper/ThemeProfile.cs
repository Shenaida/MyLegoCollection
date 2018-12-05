using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyLegoCollection.Web.Data.Entities;

namespace MyLegoCollection.Web.Business.Modules.AutoMapper
{
    public class ThemeProfile : Profile
    {
        public ThemeProfile()
        {
            CreateMap<Theme, ThemeModel>()
                .ForMember(dest => dest.Id, src => src.MapFrom(model => model.Id))
                .ForMember(dest => dest.Name, src => src.MapFrom(model => model.Name));
        }
    }
}
