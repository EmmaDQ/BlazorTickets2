namespace Shared.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace Shared.Models
    {
        public class ResponseViewModel
        {

            public int Id { get; set; }
            [Required(ErrorMessage = "Please write your response!")]
            [MinLength(1, ErrorMessage = "Response to short!")]
            public string Response { get; set; } = null!;
            public string SubmittedBy { get; set; } = null!;
            public int TicketId { get; set; }
            public TicketViewModel Ticket { get; set; } = null!;

        }

        public class TagViewModel
        {

            public int Id { get; set; }
            public string Name { get; set; } = null!;
        }

        public class TicketViewModel
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "Please write your title for the ticket!")]
            [MinLength(3, ErrorMessage = "The title is to short!")]
            public string Title { get; set; } = null!;
            [Required(ErrorMessage = "Please write your ticket!")]
            [MinLength(10, ErrorMessage = "The ticket is to short!")]
            public string? Description { get; set; }
            public string SubmittedBy { get; set; } = null!;
            public bool IsResolved { get; set; }
            public string? Image { get; set; }
            public List<ResponseViewModel> Responses { get; set; } = new List<ResponseViewModel>();
        }
    }

}
