using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkMonitoring.Pages
{
    public class ConsoleModel : PageModel
    {
        private readonly ILogger<ConsoleModel> _logger;

        public ConsoleModel(ILogger<ConsoleModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
