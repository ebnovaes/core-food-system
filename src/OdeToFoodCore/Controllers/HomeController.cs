using Microsoft.AspNetCore.Mvc;
using OdeToFoodCore.Models;

namespace OdeToFoodCore.Controllers
{
    public class HomeController : Controller
    {
        public ObjectResult Index()
        {
            var model = new Restaurant() { Id = 1, Name = "Sabatino's" };
            return new ObjectResult(model);
        }
    }
}
