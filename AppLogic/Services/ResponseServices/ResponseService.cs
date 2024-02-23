using Newtonsoft.Json;
using Shared.Models;
using System.Net.Http.Json;

namespace AppLogic.Services.ResponseServices
{
    public class ResponseService : IResponseService
    {
        public HttpClient Client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7249/api/BlazorTicket/")
        };


        public async Task<List<ResponseModel>> GetResponses()
        {
            var response = await Client.GetAsync("Responses");

            if (response.IsSuccessStatusCode)
            {
                string ticketjson = await response.Content.ReadAsStringAsync();

                List<ResponseModel>? responses = JsonConvert.DeserializeObject<List<ResponseModel>>(ticketjson);

                if (responses != null)
                {
                    return responses;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostResponse(ResponseModel response)
        {
            await Client.PostAsJsonAsync("responses", response);
        }
    }
}
