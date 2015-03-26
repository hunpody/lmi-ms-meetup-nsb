using System;
using NServiceBus;
using ClassTrip.Contracts.Offers;


namespace ClassTrip.Offers
{
    public partial class RequestCompletedHandler
    {
		
        partial void HandleImplementation(RequestCompleted message)
        {
            // TODO: RequestCompletedHandler: Add code to handle the RequestCompleted message.
            Console.WriteLine("Offers received " + message.GetType().Name);
        }

    }
}
