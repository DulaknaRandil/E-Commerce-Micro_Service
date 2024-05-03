using AutoMapper;
using E_Commerce.Services.ShoppingCartAPI.Models;
using E_Commerce.Services.ShoppingCartAPI.Models.Dto;

namespace E_Commerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<CartHeader, CartHeaderDto>(). ReverseMap();
                    config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();

                });
            return mappingConfig;
        }
    }
}
