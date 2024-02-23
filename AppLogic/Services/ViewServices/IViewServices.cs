using Shared.Models.Shared.Models;
using static Shared.Models.ApiModels;

namespace AppLogic.Services.ViewServices
{
    public interface IViewServices
    {
        public TicketAPIModel TicketApi { get; set; }
        public ResponseAPIModel ResponseApi { get; set; }
        public TicketViewModel TicketView { get; set; }
        public ResponseViewModel ResponseViewModel { get; set; }

        public Task<List<TicketAPIModel>> GetAPITickets();

        public Task PostTicket(TicketAPIModel ticket);

        public Task<List<TicketAPIModel>> GetAPIResponse();

        public Task PostTicket(ResponseAPIModel ticket);
    }
}
