using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages
{
    public class SeeModel : PageModel
    {
        private readonly ILogger<SeeModel> _logger;

        public SeeModel(ILogger<SeeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            
        }
    }
}