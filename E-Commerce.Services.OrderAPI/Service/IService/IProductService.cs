

using E_Commerce.Services.OrderAPI.Models.Dto;

namespace E_Commerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
