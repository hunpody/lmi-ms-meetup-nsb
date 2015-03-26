using System;
using System.Collections.Generic;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;
using NServiceBus.Saga;


namespace ClassTrip.Offers
{
    public partial class OfferSagaSagaData
    {
        public Guid RequestId { get; set; }
        public List<MakeOffer> Offers { get; set; }

        public OfferSagaSagaData()
        {
            Offers = new List<MakeOffer>();
        }
    }
}
