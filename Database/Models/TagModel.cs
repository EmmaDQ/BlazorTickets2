using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class TagModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<TicketTag> TicketTags { get; set; } = new List<TicketTag>();
    }
}
