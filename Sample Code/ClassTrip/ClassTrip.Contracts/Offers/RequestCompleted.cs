using System;
using ClassTrip.Internal.Commands.Offers;

namespace ClassTrip.Contracts.Offers
{
    public class RequestCompleted
    {
        public RequestOffer Request { get; set; }
        public MakeOffer AcceptedOffer { get; set; }
    }
}
