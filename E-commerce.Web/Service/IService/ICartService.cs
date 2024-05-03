using E_commerce.Web.Models;
using E_Commerce.Web.Models;
//using E_Commerce.Web.Models;

namespace E_commerce.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsnyc(string userId);
        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId);
        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);
       // Task<ResponseDto?> EmailCart(CartDto cartDto);
    }
}
