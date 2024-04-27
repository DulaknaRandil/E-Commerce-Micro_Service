using E_Commerce.Web.Models;

namespace E_commerce.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCoupon(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetAllCouponsByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponsAsync(int id);


    }
}
