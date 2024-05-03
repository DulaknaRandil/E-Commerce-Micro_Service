using E_Commerce.Services.AuthAPI.Models;

namespace E_Commerce.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser,IEnumerable<string>roles);
    }
}
