using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClassTrip.Internal.Commands.Offers;
using ClassTrip.Offers;

namespace ClassTrip.UserInterface.Controllers
{
    public partial class TestMessagesController
    {
        public ActionResult RequestOffer(RequestOffer command)
        {
            RequestOfferSender.Send(command);
            return new HttpStatusCodeResult(HttpStatusCode.Accepted);
        }

        public ActionResult Accept(AcceptOffer command)
        {
            AcceptOfferSender.Send(command);
            return new HttpStatusCodeResult(HttpStatusCode.Accepted);
        }

        public ActionResult Main()
        {
            return View();
        }
    }
}

