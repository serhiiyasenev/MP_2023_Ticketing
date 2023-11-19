using Ticketing.DAL.Enums;

namespace Ticketing.DAL.Entities
{
    public class Price
    {
        public int PriceId { get; set; }
        public int OfferId { get; set; }
        public PriceLevel Level { get; set; }
        public decimal Amount { get; set; }
        public Offer Offer { get; set; }
    }
}
