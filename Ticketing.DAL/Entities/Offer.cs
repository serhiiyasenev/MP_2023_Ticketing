using System.Diagnostics;

namespace Ticketing.DAL.Entities
{
    public class Offer
    {
        public int OfferId { get; set; }
        public string Description { get; set; }
        public List<Price> Prices { get; set; }
    }
}
