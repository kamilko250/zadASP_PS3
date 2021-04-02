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
    public class DetailsModel : PageModel
    {
        private readonly PS3.Data.FizzBuzzContext _context;

        public DetailsModel(PS3.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzzes.FirstOrDefaultAsync(m => m.ID == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
