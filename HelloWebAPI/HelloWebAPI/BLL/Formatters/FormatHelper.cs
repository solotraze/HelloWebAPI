using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebAPI.BLL.Formatters
{
    public class FormatHelper
    {
        private static char[] _specialChars = new char[] { ',', '\n', '\r', '"' };

        public static string Escape(object o)
        {
            if (o == null)
            {
                return "";
            }
            string field = o.ToString();
            if (field.IndexOfAny(_specialChars) != -1)
            {
                // Delimit the entire field with quotes and replace embedded quotes with "".
                return String.Format("\"{0}\"", field.Replace("\"", "\"\""));
            }
            else return field;
        }
    }
}