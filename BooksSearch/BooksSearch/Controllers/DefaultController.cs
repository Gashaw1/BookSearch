using BookModelsLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebServiceProject;

namespace BooksSearch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index(string search)
        {
            if (search != null)
            {
                var result = new List<items>();
                result = await GoogleAPIs.Results(search);
                return View(result.ToList());
            }
            else
            {
                var result = new List<items>();
                result = await GoogleAPIs.Results();
                return View(result.ToList());
            }
          
        }

        public async Task<PartialViewResult> Index2(string search)
        {
            var result = new List<items>();
            result = await GoogleAPIs.Results(search);
            return PartialView(result.ToList());
        }
    }
}