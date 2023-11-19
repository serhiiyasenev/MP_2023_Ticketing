using Ticketing.DAL.Enums;

namespace Ticketing.DAL.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public int SeatId { get; set; }
        public int CustomerId { get; set; }
        public TicketStatus Status { get; set; }
        public Event Event { get; set; }
        public Seat Seat { get; set; }
        public User Customer { get; set; }
    }
}
