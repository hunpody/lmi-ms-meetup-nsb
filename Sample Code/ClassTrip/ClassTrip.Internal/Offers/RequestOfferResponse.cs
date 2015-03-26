using System;
using ClassTrip.Internal.Commands.Offers;

namespace ClassTrip.Internal.Messages.Offers
{
    public class RequestOfferResponse
    {
        public RequestOffer Request { get; set; }
        public bool IsOk { get; set; }
    }
}
