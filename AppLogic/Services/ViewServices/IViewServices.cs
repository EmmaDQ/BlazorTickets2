using Shared.Models;
using Shared.Models.Shared.Models;
using static Shared.Models.ApiModels;

namespace AppLogic.Services.ViewServices
{
    internal interface IViewServices
    {
        public TicketAPIModel TicketApi { get; set; }
        public ResponseAPIModel ResponseApi { get; set; }
        public TicketViewModel TicketView { get; set; }
        public ResponseViewModel ResponseViewModel { get; set; }

        public Task<List<TicketModel>> GetAPITickets();

        public Task PostTicket(TicketAPIModel ticket);

        public Task<List<TicketModel>> GetAPIResponse();

        public Task PostTicket(ResponseAPIModel ticket);
    }
}
