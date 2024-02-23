using Database.DbConnection;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlazorTicketController : Controller
    {

        public static List<TicketModel> Tickets { get; set; } = new()
        {
            new TicketModel()
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                SubmittedBy = "TestUser",
                IsResolved = true,
            },
            new TicketModel()
            {
                Id=2,
                Title = "Test2",
                Description = "Test2",
                SubmittedBy = "TestUser2",
                IsResolved= false,

            }
        };

        public static List<ResponseModel> Responses { get; set; } = new()
        {
            new ResponseModel()
            {
                Id=1,
                Response = "This is a test",
                SubmittedBy = "Åke",
                TicketId = 1,

            },
            new ResponseModel()
            {
                Id = 2,
                Response = "This is another test",
                SubmittedBy = "Bengt",
                TicketId = 2,
            }
        };

        private readonly AppDbContext _context;

        public BlazorTicketController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("Tickets")]
        public ActionResult<List<TicketModel>> GetTickets()
        {
            return Ok(Tickets);
        }

        [HttpGet("Responses")]
        public ActionResult<List<ResponseModel>> GetReponses()
        {
            return Ok(Responses);
        }


        [HttpPost("Ticket")]
        public ActionResult PostTicket(TicketModel ticket)
        {
            if (ticket != null)
            {
                Tickets.Add(ticket);
                return Ok();
            }

            return BadRequest();
        }



        [HttpPost("Response")]
        public ActionResult PostResponse(ResponseModel response)
        {
            if (response != null)
            {
                Responses.Add(response);
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("Ticket/{id}")]
        public ActionResult DeleteTicket(int id)
        {
            var ticket = Tickets.FirstOrDefault(x => x.Id == id);

            if (ticket == null)
            {
                return NotFound();
            }

            Tickets.Remove(ticket);

            return NoContent();
        }

        [HttpDelete("Response/{id}")]
        public ActionResult DeleteResponse(int id)
        {
            var response = Responses.FirstOrDefault(x => x.Id == id);

            if (response == null)
            {
                return NotFound();
            }

            Responses.Remove(response);

            return NoContent();

        }
    }
}
