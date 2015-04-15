using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Data.Entities;
using System.Net.Http;
using System.Web.Http;
using Web.Common.Routing;

namespace Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("venue")]
    public class VenueController : ApiController
    {

        [Route("", Name = "AddVenueRoute")]
        public Venue PostVenue(HttpRequestMessage requestMessage, Venue newVenue)
        {
            return new Venue
            {
                
            };
        }
    }
}
