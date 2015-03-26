using System;
using ClassTrip.Internal.Messages.Offers;
using Newtonsoft.Json;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;
using ClassTrip.Contracts.Offers;


namespace ClassTrip.Offers
{
    public partial class OfferRequestedHandler : IHandleMessages<ScheduledMakeOffer>
    {
		
        partial void HandleImplementation(OfferRequested message)
        {
            Console.WriteLine("Offers received " + message.GetType().Name + ": " +
                              JsonConvert.SerializeObject(message));


            var random = new Random();

            var numberOfOffers = random.Next(2, 4);
            for (int i = 0; i < numberOfOffers; ++i)
            {
                Bus.Defer(TimeSpan.FromSeconds((i + 1)*2),
                    new ScheduledMakeOffer
                    {
                        MakeOffer = new MakeOffer
                        {
                            Id = Guid.NewGuid(),
                            RequestId = message.Request.Id,
                            Price =
                                random.Next(100, 1000)*message.Request.HeadCount
                        }
                    });
            }
        }

        public void Handle(ScheduledMakeOffer message)
        {
            if (new Random().Next(4) == 0)
            {
                throw new Exception("Website down");
            }
            Bus.Send(message.MakeOffer);
        }
    }
}
