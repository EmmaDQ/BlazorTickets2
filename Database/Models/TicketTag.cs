namespace Database.Models
{
    public class TicketTag
    {
        public int TicketId { get; set; }
        public TicketModel Ticket { get; set; } = null!;
        public int TagId { get; set; }
        public TagModel Tag { get; set; } = null!;

    }
}
