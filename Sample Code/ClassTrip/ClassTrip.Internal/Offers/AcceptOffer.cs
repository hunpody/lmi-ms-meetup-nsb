using System;

namespace ClassTrip.Internal.Commands.Offers
{
    public class AcceptOffer
    {
        public Guid RequestId { get; set; }
        public Guid OfferId { get; set; }
    }
}
