using ProvaAudaz.Model;
using ProvaAudaz.Service;;

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
