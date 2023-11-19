namespace Ticketing.DAL.Entities
{
    public class Manifest
    {
        public int ManifestId { get; set; }
        public int VenueId { get; set; }
        public string Details { get; set; }
        public Venue Venue { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
