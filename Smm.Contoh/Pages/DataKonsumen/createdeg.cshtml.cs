using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smm.Contoh.Data;
using Smm.Contoh.ServiceApplication.Dto;

namespace Smm.Contoh.Pages.DataKonsumen
{
    public class createdegModel : PageModel
    {
        private readonly Smm.Contoh.Data.ApplicationDbContext _context;

        public createdegModel(Smm.Contoh.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataKonsumenDto DataKonsumenDto { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DataKonsumenDto.Add(DataKonsumenDto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
