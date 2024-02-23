using Shared.Models;
using Shared.Models.Shared.Models;

namespace AppLogic.Services.ViewServices
{
    internal class ViewServices : IViewServices
    {
        public ApiModels.TicketAPIModel TicketApi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ApiModels.ResponseAPIModel ResponseApi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TicketViewModel TicketView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResponseViewModel ResponseViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<List<TicketViewModel>> GetAPIResponse()
        {
            foreach (TicketAPIModel)
        }

        public Task<List<TicketModel>> GetAPITickets()
        {
            throw new NotImplementedException();
        }

        public Task PostTicket(ApiModels.TicketAPIModel ticket)
        {
            throw new NotImplementedException();
        }

        public Task PostTicket(ApiModels.ResponseAPIModel ticket)
        {
            throw new NotImplementedException();
        }
    }
}
