using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PS3.Data;
using PS3.Models;

namespace PS3.Pages.FizzBuzzes
{
    public class IndexModel : PageModel
    {
        private readonly PS3.Data.FizzBuzzContext _context;

        public IndexModel(PS3.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IList<FizzBuzz> FizzBuzz { get;set; }

        public async Task OnGetAsync()
        {
            FizzBuzz = await _context.FizzBuzzes.OrderByDescending(p => p.DateTime).Take(10).ToListAsync();
        }
    }
}
