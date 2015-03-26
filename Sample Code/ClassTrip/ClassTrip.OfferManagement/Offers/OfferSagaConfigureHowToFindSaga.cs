using System;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;
using NServiceBus.Saga;


namespace ClassTrip.Offers
{
    public partial class OfferSaga
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<OfferSagaSagaData> mapper)
        {
            mapper.ConfigureMapping<MakeOffer>(m => m.RequestId)
                .ToSaga(s => s.RequestId);

            mapper.ConfigureMapping<AcceptOffer>(m => m.RequestId)
                .ToSaga(s => s.RequestId);

            // If you add new messages to be handled by your saga, you will need to manually add a call to ConfigureMapping for them.
        }
    }
}
