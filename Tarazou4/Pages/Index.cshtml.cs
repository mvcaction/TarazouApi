using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarazou4.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }

        public void OnGet()
        {
            FullName = "Nancy Davolio";
            ViewData["heading"] = "Welcome to ASP.NET Core Razor Pages !!";
        }
    }
}