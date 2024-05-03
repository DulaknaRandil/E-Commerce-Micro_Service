using E_Commerce.Services.ShoppingCartAPI.Models.Dto;

namespace E_Commerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
