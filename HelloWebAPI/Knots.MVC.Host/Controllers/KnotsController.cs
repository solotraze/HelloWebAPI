using Knots.Common.Interfaces.Services;
using Knots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Knots.MVC.Host.Controllers
{
    public class KnotsController : ApiController
    {
        private readonly IKnotsService _knotsService;
        public KnotsController(IKnotsService knotsBal)
        {
            _knotsService = knotsBal;
        }

        // GET: api/values
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_knotsService.GetAllKnots());
        }

        // GET api/values/5
        [HttpGet()]
        public async Task<IHttpActionResult> Get(int id)
        {
            var knot = await _knotsService.FindKnot(id);
            if (knot != null)
            {
                return Ok(knot);
            }
            else
            {
                return NotFound();
            }
        }

        /*
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
