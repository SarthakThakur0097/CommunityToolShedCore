using CommunityToolShedCore.Models;
using CommunityToolShedCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
        public IActionResult AddMember()
        {
            AddMemberViewModel viewModel = new AddMemberViewModel();
            using(_context)
            {
                viewModel.AllUsers = new SQLUserRepository(_context).GetAllUsers();
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddMember(int id)
        {

            return View();
        }
        
        [HttpGet]
        public IActionResult Members(int Id)
        {
            CommunityMembersViewModel viewModel = new CommunityMembersViewModel();
            using(_context)
            {
                IList<CommunityMember> CommunityMembers = new SQLCommunityRepository(_context).GetAllMembersByCommunityId(Id);

                viewModel.CommunityMembers = CommunityMembers;
 
            }

            return View(viewModel);
        }
    }
}