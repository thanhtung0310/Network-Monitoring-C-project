using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkMonitoring.Pages
{
    public class consoleModel : PageModel
    {
        private readonly ILogger<consoleModel> _logger;

        public consoleModel(ILogger<consoleModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
