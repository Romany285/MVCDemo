using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "this is index action";
        }
        public string AboutUs()
        {
            return "this is About Us action";
        }
    }
}
