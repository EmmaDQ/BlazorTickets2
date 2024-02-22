using AppLogic.DummyModels;

namespace UIBlazorTickets.Services.ResponseServices
{
	public interface IResponseService
	{
		public HttpClient Client { get; set; }

		public Task<List<ResponseModel>> GetResponses();

		public Task PostResponse(ResponseModel response);
	}
}
