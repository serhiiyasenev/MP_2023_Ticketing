namespace Ticketing.DAL.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
