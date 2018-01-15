using BookModelsLayer.Models;
using BooksSearch.GoogleAPIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

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
    }
}