namespace Database.DbConnection
{
    public class TicketRepo<T> where T : class
    {
        private readonly AppDbContext _context;

        public TicketRepo(AppDbContext context)
        {
            _context = context;
        }

    }

}
