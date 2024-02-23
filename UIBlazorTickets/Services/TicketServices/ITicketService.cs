using Shared.Models;

namespace UIBlazorTickets.Services.TicketServices
{
    public interface ITicketService
    {
        public HttpClient Client { get; set; }

        public Task<List<TicketModel>> GetTickets();

        public Task PostTicket(TicketModel ticket);
    }
}
