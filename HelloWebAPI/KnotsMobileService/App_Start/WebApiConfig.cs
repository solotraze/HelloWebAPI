using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Web.Http;
using KnotsMobileService.DataObjects;
using KnotsMobileService.Models;
using Microsoft.WindowsAzure.Mobile.Service;

namespace KnotsMobileService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            Database.SetInitializer(new MobileServiceInitializer());
        }
    }

    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<MobileServiceContext>
    {
        protected override void Seed(MobileServiceContext context)
        {
            List<Knot> knots = new List<Knot>
            {
                new Knot { Id = Guid.NewGuid().ToString(), Title = "First item", Content = "Detailed content 1."},
                new Knot { Id = Guid.NewGuid().ToString(), Title = "Second item", Content = "Detailed content 2." },
            };

            foreach (var item in knots)
            {
                context.Set<Knot>().Add(item);
            }

            base.Seed(context);
        }
    }
}

