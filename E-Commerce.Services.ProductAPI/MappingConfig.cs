﻿using AutoMapper;
using E_Commerce.Services.ProductAPI.Models;
using E_Commerce.Services.ProductAPI.Models.Dto;

namespace E_Commerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<ProductDto, Product>(). ReverseMap();
                   
                });
            return mappingConfig;
        }
    }
}
