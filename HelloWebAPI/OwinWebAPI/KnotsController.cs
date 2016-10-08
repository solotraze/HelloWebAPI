using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebAPI
{
    public class KnotsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "text1", "text2" };
        }
    }
}
