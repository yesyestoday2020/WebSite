using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.Two
{
    public class TwoModel : PageModel
    {
        private readonly ILogger<TwoModel> _logger;
        
        public TwoModel(ILogger<TwoModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            
        }
    }
}