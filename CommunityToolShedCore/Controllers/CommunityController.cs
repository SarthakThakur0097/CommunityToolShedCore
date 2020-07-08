using CommunityToolShedCore.Models;
using CommunityToolShedCore.Repositories;
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
        public IActionResult AddMember(int communityId)
        {
            AddMemberViewModel viewModel = new AddMemberViewModel();
            viewModel.CommunityId = communityId;

            using(_context)
            {
                viewModel.AllUsers = new SQLUserRepository(_context).GetAllUsers();
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddMember(int communityId, string userId)
        {
            using (_context)
            {
                Community communityToJoin = new SQLCommunityRepository(_context).GetById(communityId);
                ApplicationUser user = new SQLUserRepository(_context).GetById(userId);

            }
            return View();
        }
        
        [HttpGet]
        public IActionResult Members(int id)
        {
            CommunityMembersViewModel viewModel = new CommunityMembersViewModel();
            viewModel.CommunityId = id;
            using(_context)
            {
                IList<CommunityMember> CommunityMembers = new SQLCommunityRepository(_context).GetAllMembersByCommunityId(id);

                viewModel.CommunityMembers = CommunityMembers;
 
            }

            return View(viewModel);
        }
    }
}