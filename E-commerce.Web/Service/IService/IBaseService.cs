using E_commerce.Web.Models;


namespace E_commerce.Web.Service.IService
{
    public interface IBaseService
    {
        Task <ResponseDto?> SendAsync(RequestDto requestDto,bool withBearer=true);
    }
}
