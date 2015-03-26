using System;

namespace ClassTrip.Internal.Commands.Offers
{
    public class MakeOffer
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public decimal Price { get; set; }
    }
}
