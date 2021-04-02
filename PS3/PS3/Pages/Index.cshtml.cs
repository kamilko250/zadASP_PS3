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
using PS3.Data;

namespace PS3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FizzBuzzContext _context;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
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
            FizzBuzz.FizzBuzzing();
            HttpContext.Session.SetString("FizzBuzz", JsonConvert.SerializeObject(FizzBuzz));
            _context.Add(FizzBuzz);

            _context.SaveChanges();
            return Page();
        }

    }
}
