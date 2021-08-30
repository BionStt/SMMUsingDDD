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
    public class DetailsModel : PageModel
    {
        private readonly Smm.ContohRazor.Data.ApplicationDbContext _context;

        public DetailsModel(Smm.ContohRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
