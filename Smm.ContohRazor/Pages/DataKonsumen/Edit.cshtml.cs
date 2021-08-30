using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smm.ContohRazor.Data;

namespace Smm.ContohRazor.Pages.DataKonsumen
{
    public class EditModel : PageModel
    {
        private readonly Smm.ContohRazor.Data.ApplicationDbContext _context;

        public EditModel(Smm.ContohRazor.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DataKonsumen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataKonsumenExists(DataKonsumen.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DataKonsumenExists(int id)
        {
            return _context.DataKonsumen.Any(e => e.Id == id);
        }
    }
}
