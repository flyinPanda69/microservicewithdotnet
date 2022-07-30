using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetAllProductByIdAsync<T>(int id);
        Task<T> CreateProductsAsync<T>(ProductDto productDto);
        Task<T> UpdateProductsAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
