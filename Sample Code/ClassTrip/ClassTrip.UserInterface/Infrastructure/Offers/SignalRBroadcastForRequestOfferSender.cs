﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NServiceBus;
using Microsoft.AspNet.SignalR;
using ClassTrip.Internal.Messages.Offers;

namespace ClassTrip.Offers
{

	public class BroadcastRequestOfferResponse : IHandleMessages<RequestOfferResponse>
	{
		public void Handle(RequestOfferResponse message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<RequestOfferResponseHub>();
            context.Clients.All.requestOfferResponse(message); 
        }
	}        
}