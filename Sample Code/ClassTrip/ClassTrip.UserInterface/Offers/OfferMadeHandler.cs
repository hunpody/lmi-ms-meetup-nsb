using System;
using NServiceBus;
using ClassTrip.Contracts.Offers;


namespace ClassTrip.Offers
{
    public partial class OfferMadeHandler
    {
		
        partial void HandleImplementation(OfferMade message)
        {
            // TODO: OfferMadeHandler: Add code to handle the OfferMade message.
            Console.WriteLine("Offers received " + message.GetType().Name);
        }

    }
}
