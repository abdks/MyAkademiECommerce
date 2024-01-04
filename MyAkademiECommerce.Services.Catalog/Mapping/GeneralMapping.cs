using AutoMapper;
using MyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAkademiECommerce.Services.Catalog.Models;

namespace MyAkademiECommerce.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<ResultCategoryDto, Category>();
            CreateMap<Category,CreateCategoryDto>();
            CreateMap<Category,UpdateCategoryDto>();
            CreateMap<Product,ResultProductDto>();
            CreateMap<Product,CreateProductDto>();
            CreateMap<Product,UpdateProductDto>();

        }
    }
}
