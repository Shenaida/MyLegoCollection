using AutoMapper;
using MyLegoCollection.Web.Modules.Automapper;

namespace MyLegoCollection.Web.Test
{
    public static class AutoMapperFixture
    {
        public static IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile<LegoSetProfile>();
            });

            mapperConfiguration.AssertConfigurationIsValid();

            return mapperConfiguration.CreateMapper();
        }
    }
}