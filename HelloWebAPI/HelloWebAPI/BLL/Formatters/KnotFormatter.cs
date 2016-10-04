using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.IO;
using System.Net.Http;

namespace HelloWebAPI.BLL.Formatters
{
    public class KnotFormatter : BufferedMediaTypeFormatter
    {
        public KnotFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/knot"));
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

        public override void WriteToStream(Type type, object value, Stream writeStream, HttpContent content)
        {
            using (var writer = new StreamWriter(writeStream))
            {
                var knotObj = value as Knot;
                if (knotObj != null)
                {
                    WriteSingleItem(knotObj, writer);
                }
                else
                {
                    throw new InvalidOperationException("Cannot serilize type.");
                }
            }
        }

        private void WriteSingleItem(Knot obj, StreamWriter writer)
        {
            writer.WriteLine("{0} ({1})\r\n{2}\r\n---------", FormatHelper.Escape(obj.Title),
                FormatHelper.Escape(obj.KnotId), FormatHelper.Escape(obj.Content));
        }
    }
}