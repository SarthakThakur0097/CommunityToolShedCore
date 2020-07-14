using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CommunityToolShedCore.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
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
            ListAllCommunitiesViewModel viewModel = new ListAllCommunitiesViewModel();

            using(_context)
            {
                IList<Community> allCommunities = new SQLCommunityRepository(_context).GetAllCommunities();
                viewModel.AllCommunities = allCommunities;
            }
            return View(viewModel);
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
