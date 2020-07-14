using System.Threading.Tasks;
using CommunityToolShedCore.Models;
using CommunityToolShedCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using CommunityToolShedCore.Repositories;
using System.Collections.Generic;

namespace CommunityToolShedCore.Controllers
{
    public class ToolController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<ToolController> _logger;
        private UserManager<ApplicationUser> _userManager;
        public ToolController(ILogger<ToolController> logger, Context context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListAllToolsForCommunity(int communityId)
        {
            ListToolsApplicationUserViewModel viewModel = new ListToolsApplicationUserViewModel(); 
            using(_context)
            {
                IList<ToolCommunityMember> allTools = new SQLToolCommunityMemberRepository(_context).GetAllToolsByCommunityId(communityId);
                viewModel.ToolCommunityMembers = allTools;
                if(allTools.Count == 0) { }
                    //TODO: Implement what happens when a community has members but no members have added any tools
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddTool()
        {
            AddToolViewModel formModel = new AddToolViewModel();
            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddTool(AddToolViewModel viewModel)
        {
            using(_context)
            {
                var user = await _userManager.GetUserAsync(User);

                Tool toolToAdd = new Tool(viewModel.Name, viewModel.Description);
                CommunityMember communityMember = new SQLCommunityMembersRepository(_context).GetCommunityMemberByUserId(user.Id);
                toolToAdd.ToolApplicationUsers.Add(new ToolCommunityMember
                {
                    ToolId = toolToAdd.Id,
                    CommunityMemberId = communityMember.Id,
                    IsBorrowed = false,
                    IsOwner = true
                });

                var toolAddCheck = new SQLToolRepository(_context).Add(toolToAdd);
                if (toolAddCheck == null)
                {
                    //TODO: Implement
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UserTools(string id)
        {
            using(_context)
            {

            }
            return View();
        }
    }
}
