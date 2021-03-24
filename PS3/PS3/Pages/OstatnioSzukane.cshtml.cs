using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace PS3.Pages
{
    public class OstatnioSzukaneModel : PageModel
    {
        [BindProperty]
        public string Result { get; set; }
        [BindProperty]
        public string Number { get; set; }
        [BindProperty]
        public DateTime DateTime { get; set; }
        public IActionResult OnGet()
        {
            Result = HttpContext.Session.GetString("Result");
            Number = HttpContext.Session.GetString("Number");
            var dateTime = HttpContext.Session.GetString("Date");

            if (dateTime != null)
                DateTime = JsonConvert.DeserializeObject<DateTime>(dateTime);

            return Page();
        }
        
    }
}
