using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        public readonly IHttpClientFactory _httpClientFactory;
        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<T> CreateProductsAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                APIType = SD.APIType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase +"api/product/",
                AcessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                APIType = SD.APIType.DELETE,
                Url = SD.ProductAPIBase + "api/product/"+id,
                AcessToken = ""
            });
        }

        public async Task<T> GetAllProductByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                APIType = SD.APIType.GET,
                Url = SD.ProductAPIBase + "api/product/" + id,
                AcessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                APIType = SD.APIType.GET,
                Url = SD.ProductAPIBase + "api/product/",
                AcessToken = ""
            });
        }

        public async Task<T> UpdateProductsAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                APIType = SD.APIType.PUT,
                Data = productDto,
                Url = SD.ProductAPIBase + "api/product/",
                AcessToken = ""
            });
        }
    }
}
