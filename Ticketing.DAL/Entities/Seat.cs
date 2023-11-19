using System.Net.Sockets;

namespace Ticketing.DAL.Entities
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int ManifestId { get; set; }
        public string RowNumber { get; set; }
        public string SeatNumber { get; set; }
        public string Type { get; set; }
        public Manifest Manifest { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
