using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkMonitoring.Pages
{
    public class GraphsModel : PageModel
    {
        private readonly ILogger<GraphsModel> _logger;

        public GraphsModel(ILogger<GraphsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
