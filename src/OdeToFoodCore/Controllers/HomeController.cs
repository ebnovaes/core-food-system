using Microsoft.AspNetCore.Mvc;
using OdeToFoodCore.Models;
using OdeToFoodCore.Services;

namespace OdeToFoodCore.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public ViewResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }

        private IRestaurantData _restaurantData;
    }
}