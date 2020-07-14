using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommunityToolShedCore.Controllers
{
    public class ToolController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<ToolController> _logger;

        public ToolController(ILogger<ToolController> logger, Context context)
        {
            _context = context;
        }
        public IActionResult UserTools(int id)
        {
            return View();
        }
    }
}
