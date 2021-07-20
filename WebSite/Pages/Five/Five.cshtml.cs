using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.Five
{
    public class FiveModel: PageModel
    {
        private readonly ILogger<FiveModel> _logger;
        
        public FiveModel(ILogger<FiveModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
            
        }
    }
}