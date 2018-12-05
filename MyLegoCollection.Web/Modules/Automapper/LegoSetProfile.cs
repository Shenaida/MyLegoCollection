using AutoMapper;
using MyLegoCollection.Web.Business.Commands;
using MyLegoCollection.Web.Business.Models;
using MyLegoCollection.Web.Data.Entities;
using MyLegoCollection.Web.Models.CollectionViewModels;
using MyLegoCollection.Web.Models.HomeViewModels;

namespace MyLegoCollection.Web.Modules.Automapper
{
    public sealed class LegoSetProfile : Profile
    {
        public LegoSetProfile()
        {
            CreateMap<LegoSetModel, LegoSetViewModel>();
            CreateMap<LegoSet, LegoSetModel>();
            CreateMap<AddLegoSetViewModel, AddLegoSetCommand>()
                .ForMember(dest => dest.Theme, opt => opt.MapFrom(src => src.SelectedTheme))
                ;
            CreateMap<AddLegoSetCommand, LegoSet>()
                .ForMember(dest => dest.SetId, src => src.Ignore());
        }
    }
}