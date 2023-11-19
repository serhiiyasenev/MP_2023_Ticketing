namespace Ticketing.DAL.Entities
{
    public class EventManager
    {
        public int EventManagerId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Event> ManagedEvents { get; set; }
    }
}
