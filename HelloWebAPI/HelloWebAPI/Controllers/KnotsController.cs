using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    [RoutePrefix("api/Knots")]
    public class KnotsController : ApiController
    {
        [Route("")]
        public string GetKnots()
        {
            return string.Format("Here are all the knots.");
        }

        [Route("{id:int}")]
        public string GetKnotsById(int id)
        {
            return string.Format("Hello {0}", id);
        }
    }
}
