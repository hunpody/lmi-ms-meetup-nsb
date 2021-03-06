﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using ClassTrip.Internal.Commands.Offers;
using NServiceBus.Saga;


namespace ClassTrip.Offers
{
    public partial class OfferSaga : Saga<OfferSagaSagaData>, IAmStartedByMessages<RequestOffer>, IHandleMessages<MakeOffer>, IHandleMessages<AcceptOffer>
    {
		
		public void Handle(RequestOffer message)
		{
			// Store message in Saga Data for later use
			this.Data.RequestOffer = message;
			// Handle message on partial class
			this.HandleImplementation(message);

			// Check if Saga is Completed 
			CheckIfAllMessagesReceived();
		}

		public void Handle(MakeOffer message)
		{
			// Store message in Saga Data for later use
			this.Data.MakeOffer = message;
			// Handle message on partial class
			this.HandleImplementation(message);

			// Check if Saga is Completed 
			CheckIfAllMessagesReceived();
		}

		public void Handle(AcceptOffer message)
		{
			// Store message in Saga Data for later use
			this.Data.AcceptOffer = message;
			// Handle message on partial class
			this.HandleImplementation(message);

			// Check if Saga is Completed 
			CheckIfAllMessagesReceived();
		}

		partial void HandleImplementation(RequestOffer message);

		partial void HandleImplementation(MakeOffer message);

		partial void HandleImplementation(AcceptOffer message);

        public void CheckIfAllMessagesReceived()
        {
            if (this.Data.RequestOffer != null && this.Data.MakeOffer != null && this.Data.AcceptOffer != null)
            {
                AllMessagesReceived();
            }
        }

        partial void AllMessagesReceived();
     }

     public partial class OfferSagaSagaData : IContainSagaData
     {
           public virtual Guid Id { get; set; }
           public virtual string Originator { get; set; }
           public virtual string OriginalMessageId { get; set; }

           public virtual RequestOffer RequestOffer { get; set; }
           public virtual MakeOffer MakeOffer { get; set; }
           public virtual AcceptOffer AcceptOffer { get; set; }

    }

	
}
