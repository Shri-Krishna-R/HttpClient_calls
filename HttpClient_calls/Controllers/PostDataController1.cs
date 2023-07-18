using Microsoft.AspNetCore.Mvc;
using HttpClient_calls.Models;

namespace HttpClient_calls.Controllers
{
    public class PostDataController1 : Controller
    {
        PostModel data = new PostModel();   
        public IActionResult PostData()
        {
            ViewBag.Data = data.getPostData(); 

            return View();
        }
    }
}
