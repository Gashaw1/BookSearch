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
        public async Task<ActionResult> Index()
        {
            var result = new List<items>();
            result = await GoogleAPIs.Results();
            return View(result.ToList());
        }

        public async Task<PartialViewResult> Index2(string userInput)
        {
            var result = new List<items>();
            result = await GoogleAPIs.Results(userInput);
            return PartialView(result.ToList());
        }
    }
}