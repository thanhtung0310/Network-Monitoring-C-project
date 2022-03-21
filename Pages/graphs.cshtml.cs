using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkMonitoring.Pages
{
    public class graphsModel : PageModel
    {
        private readonly ILogger<graphsModel> _logger;

        public graphsModel(ILogger<graphsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
