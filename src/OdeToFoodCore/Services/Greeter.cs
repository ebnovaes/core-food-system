using Microsoft.Extensions.Configuration;

namespace OdeToFoodCore.Services
{
    public class Greeter : IGreeter
    {
        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreeting()
        {
            return _configuration["greeting"];
        }

        private IConfiguration _configuration;
    }
}