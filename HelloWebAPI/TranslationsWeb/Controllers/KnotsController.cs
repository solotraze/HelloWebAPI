using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TranslationsWeb.Controllers
{
    public class KnotsController : Controller
    {
        private readonly IStringLocalizer _localizer;

        public KnotsController(IStringLocalizer<KnotsController> localizer)
        {
            _localizer = localizer;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string Greet()
        {
            return _localizer["Greetings"];
        }
    }
}
