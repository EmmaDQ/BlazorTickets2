using Newtonsoft.Json;
using Shared.Models;
using System.Net.Http.Json;


namespace UIBlazorTickets.Services.TicketServices
{
    public class TicketService : ITicketService
    {
        public HttpClient Client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7249/api/")
        };

        public async Task<List<TicketModel>> GetTickets()
        {
            var response = await Client.GetAsync("Tickets");

            if (response.IsSuccessStatusCode)
            {
                string ticketjson = await response.Content.ReadAsStringAsync();

                List<TicketModel>? tickets = JsonConvert.DeserializeObject<List<TicketModel>>(ticketjson);

                if (tickets != null)
                {
                    return tickets;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }



        public async Task PostTicket(TicketModel ticket)
        {
            await Client.PostAsJsonAsync("tickets", ticket);
        }
    }
}
