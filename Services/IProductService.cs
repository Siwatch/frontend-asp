using frontend_asp.Models;

namespace frontend_asp.Services;
public interface IProductService : IBaseService {
    Task<T> GetAllProductAsync<T>();
    Task<T> GetProductByIdAsync<T>(int id);
    Task<T> CreateProductAsync<T>(ProductDTO productDTO);
    Task<T> UpdateProductAsync<T>(ProductDTO productDTO);
    Task<T> DeleteProductAsync<T>(int id);
}