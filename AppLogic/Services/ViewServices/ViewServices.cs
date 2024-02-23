using Shared.Models.Shared.Models;
using static Shared.Models.ApiModels;

namespace AppLogic.Services.ViewServices
{
    public class ViewServices : IViewServices
    {
        public TicketAPIModel TicketApi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResponseAPIModel ResponseApi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TicketViewModel TicketView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResponseViewModel ResponseViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<List<TicketAPIModel>> GetAPIResponse()
        {
            throw new NotImplementedException();
        }

        public Task<List<TicketAPIModel>> GetAPITickets()
        {
            throw new NotImplementedException();

        }

        public Task PostTicket(TicketAPIModel ticket)
        {
            throw new NotImplementedException();
        }

        public Task PostTicket(ResponseAPIModel ticket)
        {
            throw new NotImplementedException();
        }
    }
}
