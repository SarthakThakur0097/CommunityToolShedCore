using CommunityToolShedCore.Models;
using CommunityToolShedCore.ViewModels;
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

        [HttpGet]
        public IActionResult Index()
        {
            SQLCommunityRepository communityRepository;

            using(_context)
            {
                communityRepository = new SQLCommunityRepository(_context);
                
                return View(communityRepository.GetAllCommunities());
            }
        }
            
        [HttpGet]
        public IActionResult CreateCommunity()
        {
            CreateCommunityViewModel viewModel = new CreateCommunityViewModel(); 

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateCommunity(CreateCommunityViewModel model)
        {
            if (ModelState.IsValid)
            {
                Community communityToAdd = new Community(model.Name, model.IsOpen);
                using(_context){ new SQLCommunityRepository(_context).Add(communityToAdd); }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Members(int Id)
        {
            using(_context)
            {
                //new SQLUserRepository(_context).GetById(Id);
            }
            return View();
        }
    }
}