using System;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;


namespace ClassTrip.Offers
{
    public partial class RequestOfferSender
    {
        partial void ConfigureRequestOffer(RequestOffer message)
        {
            message.Id = Guid.NewGuid();
        }
    }
}
