using static Mango.Web.SD;

namespace Mango.Web.Models
{
    public class ApiRequest
    {
        public APIType APIType { get; set; } = APIType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AcessToken { get; set; }
    }
}
