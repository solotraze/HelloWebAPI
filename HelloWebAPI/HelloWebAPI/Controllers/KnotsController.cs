using HelloWebAPI.BLL.Repositories;
using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    //[RoutePrefix("")]
    public class KnotsController : ApiController
    {
        [Route("api/Knots")]
        public List<Knot> GetKnots()
        {
            return KnotsRepo.GetAllKnots();
        }

        [Route("api/Knots")]
        public List<Knot> GetKnots(string phrase)//ByPhrase
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return KnotsRepo.GetAllKnots();
            }
            else
            {
                return KnotsRepo.GetKnotsByPhrase(phrase);
            }
        }

        [Route("api/Knots/{id:int}")]
        public Knot GetKnotsById(int id)
        {
            return KnotsRepo.GetKnotById(id);
        }

        
    }
}
