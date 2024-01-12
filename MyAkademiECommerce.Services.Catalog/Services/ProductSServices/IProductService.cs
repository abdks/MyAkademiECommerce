using MyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;
using System.Diagnostics.CodeAnalysis;

namespace MyAkademiECommerce.Services.Catalog.Services.ProductSServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<ResultProductDto> GetProductAsync(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
    }
}
