using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.Four
{
    public class FourModel : PageModel
    {
        private readonly ILogger<FourModel> _logger;

        public FourModel(ILogger<FourModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
            
        }
    }
}