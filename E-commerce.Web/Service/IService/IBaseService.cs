using E_commerce.Web.Models;
using E_Commerce.Web.Models;

namespace E_commerce.Web.Service.IService
{
    public interface IBaseService
    {
        Task <ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
