namespace Ticketing.DAL.Entities
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Event> Events { get; set; }
        public Manifest Manifest { get; set; }
    }
}
