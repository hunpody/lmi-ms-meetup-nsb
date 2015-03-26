using System;
using System.Linq;
using ClassTrip.Contracts.Offers;
using ClassTrip.Internal.Messages.Offers;
using Newtonsoft.Json;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;
using NServiceBus.Saga;


namespace ClassTrip.Offers
{
    public partial class OfferSaga : IHandleTimeouts<OffersInvalidated>
    {		
        partial void HandleImplementation(RequestOffer message)
        {
            Console.WriteLine("Offers received {0}: {1}", message.GetType().Name,
                JsonConvert.SerializeObject(message));

            Data.RequestId = message.Id;

            Bus.Reply(new RequestOfferResponse
            {
                Request = message,
                IsOk = true
            });

            Save(message);

            Bus.Publish(new OfferRequested
            {
                Request = message
            });

            RequestTimeout<OffersInvalidated>(TimeSpan.FromSeconds(30));
        }

        partial void HandleImplementation(MakeOffer message)
        {
            Console.WriteLine("Received MakeOffer command: {0}",
                JsonConvert.SerializeObject(message));

            Data.Offers.Add(message);

            Bus.Publish(new OfferMade
            {
                Offer = message
            });
        }

        partial void HandleImplementation(AcceptOffer message)
        {
            Bus.Publish(new RequestCompleted
            {
                Request = Data.RequestOffer,
                AcceptedOffer = Data.Offers.First(x=>x.Id == message.OfferId)
            });

            MarkAsComplete();
        }

        private void Save(RequestOffer message)
        {
            if (new Random().Next(5) == 0)
            {
                throw new Exception("Deadlock");
            }
            Console.WriteLine("Saved!");
        }

        public void Timeout(OffersInvalidated state)
        {
            Console.WriteLine("Timeouted");
            Bus.Publish(new RequestCompleted
            {
                Request = Data.RequestOffer,
            });

            MarkAsComplete();            
        }
    }
}
