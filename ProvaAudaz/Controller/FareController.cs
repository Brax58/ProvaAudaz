using ProvaAudaz.Service;
using TestePleno.Models;

namespace ProvaAudaz.Controller
{
    public class FareController
    {
        private readonly FareService _fareService;

        public FareController()
        {
            _fareService = new FareService();
        }

        public void CreateFare(FareModel request)
        {
            _fareService.Create(request);
        }
    }
}
