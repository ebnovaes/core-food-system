using System.Collections.Generic;
using OdeToFoodCore.Models;

namespace OdeToFoodCore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}