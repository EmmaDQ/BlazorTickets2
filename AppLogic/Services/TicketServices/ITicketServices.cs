using Shared.Models;

namespace AppLogic.Services.TicketServices
{
    public interface ITicketServices
    {
        public HttpClient Client { get; set; }

        public Task<List<TicketModel>> GetTickets();

        public Task PostTicket(TicketModel ticket);
    }
}
