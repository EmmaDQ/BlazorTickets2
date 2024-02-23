using Database.DbConnection;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace App.Api.Controllers
{
    public class TagController : Controller
    {
        private readonly AppDbContext _context;
        private readonly GenericRepo<TagModel> _tagRepo;

        public TagController(AppDbContext context, GenericRepo<TagModel> tagRepo)
        {
            _context = context;
            _tagRepo = tagRepo;
        }


        [HttpGet("Tags")]
        public ActionResult<List<TagModel>> GetTickets()
        {
            var tickets = _tagRepo.GetAll();

            return Ok(tickets);
        }



        [HttpPost("TicketTag")]
        public ActionResult PostTicket(TagModel ticket)
        {
            if (ticket != null)
            {
                _tagRepo.Add(ticket);
                return Ok();
            }

            return BadRequest();
        }




        [HttpDelete("Tag/{id}")]
        public ActionResult DeleteTicketTag(int id)
        {
            var ticket = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (ticket != null)
            {
                _tagRepo.Delete(id);
                return Ok(ticket);
            }

            return NoContent();
        }
    }
}
