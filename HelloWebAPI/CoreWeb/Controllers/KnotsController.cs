using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnotsInterfaces.BLL;
using KnotsModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWeb.Controllers
{
    [Route("api/[controller]")]
    public class KnotsController : Controller
    {
        private readonly IKnotsBAL _knotsBal;
        public KnotsController(IKnotsBAL knotsBal)
        {
            _knotsBal = knotsBal;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Knot> Get()
        {
            return _knotsBal.GetAllKnots();
        }

        /*
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

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
