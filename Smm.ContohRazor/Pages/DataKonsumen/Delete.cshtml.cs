using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Smm.ContohRazor.Data;

namespace Smm.ContohRazor.Pages.DataKonsumen
{
    public class DeleteModel : PageModel
    {
        private readonly Smm.ContohRazor.Data.ApplicationDbContext _context;

        public DeleteModel(Smm.ContohRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DataKonsumen DataKonsumen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DataKonsumen = await _context.DataKonsumen.FirstOrDefaultAsync(m => m.Id == id);

            if (DataKonsumen == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DataKonsumen = await _context.DataKonsumen.FindAsync(id);

            if (DataKonsumen != null)
            {
                _context.DataKonsumen.Remove(DataKonsumen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
