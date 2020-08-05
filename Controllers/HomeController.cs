using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SunlightApp.Models;
using SunlightApp.Services;

namespace SunlightApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISunLightService _sunLightService;
        private readonly ISunRiseService _sunRiseService;

        public HomeController(ILogger<HomeController> logger, 
            ISunLightService sunLightService,
            ISunRiseService sunRiseService)
        {
            _logger = logger;
            _sunLightService = sunLightService;
            _sunRiseService = sunRiseService;
            ApiHelper.ApiHelper.InitializeApiHelper();
        }

        public async Task<IActionResult> Index(int? seek)
        {
            sunlightDataModel model = new sunlightDataModel();
            model = await _sunLightService.GetData(seek);

            return View(model);
        }

        public async Task<IActionResult> SunriseSunset(decimal? lat=0, decimal? lng=0)
        {
            Results model = new Results();
            model = await _sunRiseService.GetData(lat,lng);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
