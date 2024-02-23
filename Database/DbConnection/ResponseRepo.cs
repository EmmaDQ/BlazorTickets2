using Shared.Models;

namespace Database.DbConnection
{
    public class ResponseRepo
    {
        private readonly AppDbContext _context;

        public ResponseRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddResponseToDatabase(ResponseModel response)
        {
            _context.Responses.Add(response);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteResponseFromDatabase(int id)
        {
            var coinToDelete = await _context.Responses.FindAsync(id);
            if (coinToDelete != null)
            {
                _context.Responses.Remove(coinToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
