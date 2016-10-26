using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using KnotsMobileService.DataObjects;
using KnotsMobileService.Models;

namespace KnotsMobileService.Controllers
{
    public class KnotsController : TableController<Knot>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Knot>(context, Request, Services);
        }

        // GET tables/Knots
        public IQueryable<Knot> GetAllKnot()
        {
            return Query(); 
        }

        // GET tables/Knots/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Knot> GetKnot(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Knots/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Knot> PatchKnot(string id, Delta<Knot> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Knots
        public async Task<IHttpActionResult> PostKnot(Knot item)
        {
            Knot current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Knots/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteKnot(string id)
        {
             return DeleteAsync(id);
        }

    }
}