using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smm.ContohRazor.Data;

namespace Smm.ContohRazor.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Smm.ContohRazor.Data.ApplicationDbContext _context;

        public CreateModel(Smm.ContohRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataKonsumen DataKonsumen { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DataKonsumen.Add(DataKonsumen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
