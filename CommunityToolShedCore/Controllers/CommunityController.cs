using CommunityToolShedCore.Models;
using CommunityToolShedCore.Repositories;
using CommunityToolShedCore.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;

namespace CommunityToolShedCore.Controllers
{
    public class CommunityController : Controller
    {
        private readonly Context _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger<HomeController> _logger;

        public CommunityController(ILogger<HomeController> logger, Context context,
            IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
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
                string uniqueFileName = null;
                if(model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Community communityToAdd = new Community(model.Name, model.IsOpen, uniqueFileName);
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
        public IActionResult AddMember(string userJoiningId, int communityToJoinId)
        {
            using (_context)
            {
                CommunityMember communityMember = new CommunityMember(userJoiningId, communityToJoinId);
                var joinCheck = new SQLCommunityMembersRepository(_context).Add(communityMember);

                if(joinCheck == null)
                {
                    ModelState.AddModelError("Error", "This user is already a member of this community");
                    
                }
            }
            return RedirectToAction("Members", new { id = communityToJoinId});
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