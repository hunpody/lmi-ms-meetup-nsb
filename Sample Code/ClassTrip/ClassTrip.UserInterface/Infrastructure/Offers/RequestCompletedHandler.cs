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
using ClassTrip.Contracts.Offers;


namespace ClassTrip.Offers
{
    public partial class RequestCompletedHandler : IHandleMessages<RequestCompleted>
    {
		
		public void Handle(RequestCompleted message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(RequestCompleted message);

        public IBus Bus { get; set; }

    }

	
}
