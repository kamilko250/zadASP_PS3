using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PS3.Models;

namespace PS3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty]
        public string Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Result = FizzBuzz.FizzBuzzing();
            HttpContext.Session.SetString("Result", JsonConvert.SerializeObject(Result));
            HttpContext.Session.SetString("Number", JsonConvert.SerializeObject(FizzBuzz.Number));
            HttpContext.Session.SetString("Date", JsonConvert.SerializeObject(DateTime.Now));

            return Page();
        }

    }
}
