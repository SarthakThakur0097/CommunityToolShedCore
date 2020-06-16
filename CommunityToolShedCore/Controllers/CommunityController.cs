using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommunityToolShedCore.Controllers
{
    public class CommunityController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public CommunityController(ILogger<HomeController> logger, Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}