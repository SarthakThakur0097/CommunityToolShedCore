using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CommunityToolShedCore.Models;
using Microsoft.AspNetCore.Authorization;
using CommunityToolShedCore.ViewModels;

namespace CommunityToolShedCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            
            return View(_context.Users.ToList());
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int id)
        {
            SQLUserRepository userRepo = new SQLUserRepository(_context);
            User user = userRepo.GetById(id);

            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            return View(userEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if(ModelState.IsValid)
            {
                User user = new SQLUserRepository(_context).GetById(model.Id);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                new SQLUserRepository(_context).Update(user);
            }
            return RedirectToAction("index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
