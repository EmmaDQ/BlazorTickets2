using Shared.Models;

namespace Database.DbConnection
{
    public class TicketRepo<T> where T : class
    {
        private readonly AppDbContext _context;

        public TicketRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddTicketToDatabase(TicketModel ticketmodel)
        {
            _context.Tickets.Add(ticketmodel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTicketFromDatabase(int id)
        {
            var ticketToDelete = await _context.Tickets.FindAsync(id);
            if (ticketToDelete != null)
            {
                _context.Tickets.Remove(ticketToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }

}
