
using Shared.Models;

namespace AppLogic.Services.ResponseServices
{
    public interface IResponseService
    {
        public HttpClient Client { get; set; }

        public Task<List<ResponseModel>> GetResponses();

        public Task PostResponse(ResponseModel response);
    }
}
