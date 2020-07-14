using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolShedCore.Models;
using CommunityToolShedCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

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
                
                Tool toolToAdd = new Tool(viewModel.Name, viewModel.Description);
                var toolAddCheck = new SQLToolRepository(_context).Add(toolToAdd);
                ClaimsPrincipal currentUser = this.User;
                var user = await _userManager.GetUserAsync(User);
                //ToolApplicationUser toolApplicationUserToAdd = new ToolApplicationUser()
                //var toolApplicationUserCheck = new SQLToolApplicationUserRepository(_context).Add()
                var email = user.Email;
                if (toolAddCheck == null)
                {
                    //TODO: Implement
                }
            }
            return View();
        }
        public IActionResult UserTools(int id)
        {
            using(_context)
            {

            }
            return View();
        }
    }
}
