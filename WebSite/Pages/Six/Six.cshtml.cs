using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.Six
{
    public class SixModel : PageModel
    {
        private readonly ILogger<SixModel> _logger;
        
        public SixModel(ILogger<SixModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
            
        }
    }
}