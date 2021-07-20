using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.Three
{
    public class ThreeModel: PageModel
    {
        private readonly ILogger<ThreeModel> _logger;
        
        public ThreeModel(ILogger<ThreeModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
            
        }
    }
}