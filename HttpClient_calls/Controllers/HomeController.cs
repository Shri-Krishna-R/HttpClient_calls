using HttpClient_calls.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HttpClient_calls.Models;

namespace HttpClient_calls.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        PostModel data = new PostModel();
        public IActionResult PostData()
        {
            ViewBag.Data = data.getPostData();

            return View("Views/PostDataController1/PostData.cshtml");
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}