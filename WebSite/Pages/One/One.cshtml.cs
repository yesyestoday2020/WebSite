using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSite.Pages.One
{
    public class OneModel : PageModel
    {
        private readonly ILogger<OneModel> _logger;

        public OneModel(ILogger<OneModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
