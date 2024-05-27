using FLC_Web.Models.DTO;

namespace FLC_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO obj);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO obj);
    }
}
