using AutoMapper;
using Mango.Services.ProductAPI.Models;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(configs =>
            {
                configs.CreateMap<ProductDto, Product>();
                configs.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
