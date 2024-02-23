namespace Database.DbConnection
{
    public class ResponseRepo
    {
        private readonly AppDbContext _context;

        public ResponseRepo(AppDbContext context)
        {
            _context = context;
        }
    }
}
