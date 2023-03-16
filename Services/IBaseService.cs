using frontend_asp.Models;

namespace frontend_asp.Services
{
    public interface IBaseService : IDisposable
    {
         ResponseDTO responseModel {get;set;}
         Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}