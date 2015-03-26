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
using ClassTrip.Internal.Messages.Offers;


namespace ClassTrip.Offers
{
    public partial class RequestOfferSender : IRequestOfferSender, ServiceMatrix.Shared.INServiceBusComponent, IHandleMessages<RequestOfferResponse>
    {
		
        public void Send(RequestOffer message)
        {
            ConfigureRequestOffer(message);
            Bus.Send(message);
        }

        partial void ConfigureRequestOffer(RequestOffer message);

        public void Handle(RequestOfferResponse message)
        {

            // Handle message on partial class
            this.HandleImplementation(message);
        }

        partial void HandleImplementation(RequestOfferResponse message);

        public IBus Bus { get; set; }

    }

	
	public partial interface IRequestOfferSender
    {
        
        void Send(RequestOffer message);

	}

	
}
