using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnotsMobileService.DataObjects
{
    public class Knot : EntityData
    {
        //public int KnotId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}