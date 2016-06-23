﻿using OdeToFoodCore.Models;
using System.Collections.Generic;

namespace OdeToFoodCore.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Tersiguel's" },
                new Restaurant { Id = 2, Name = "LJ's and the Kat" },
                new Restaurant { Id = 3, Name = "King's Contrivance" }
            };

            
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }
}
