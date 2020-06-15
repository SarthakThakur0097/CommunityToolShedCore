using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolShedCore.Models;
using CommunityToolShedCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommunityToolShedCore.Controllers
{
    public class UserController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }
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
        public IActionResult Edit(string id)
        {
            UserEditViewModel userEditViewModel;

            using (_context)
            {
                ApplicationUser user = new SQLUserRepository(_context).GetById(id);


                userEditViewModel = new UserEditViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                };
            }
            return View(userEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                using(_context)
                { 
                    ApplicationUser user = new SQLUserRepository(_context).GetById(model.Id);
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    new SQLUserRepository(_context).Update(user);
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(UserEditViewModel model)
        {
            using(_context)
            {
                new SQLUserRepository(_context).Delete(model.Id);
            };
            
            return RedirectToAction("Index");
        }
    }
}