using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;

namespace HelloWebAPI.BLL.Formatters
{
    public class KnotFormatter : BufferedMediaTypeFormatter
    {
        public KnotFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/knot"));
        }

        public override bool CanReadType(Type type)
        {
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            if (type == typeof(Knot))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}