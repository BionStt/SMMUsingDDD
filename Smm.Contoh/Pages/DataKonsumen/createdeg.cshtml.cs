using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Smm.Contoh.Data;
using Smm.Contoh.ServiceApplication;
using Smm.Contoh.ServiceApplication.Dto;

namespace Smm.Contoh.Pages.DataKonsumen
{
    public class createdegModel : PageModel
    {
        private readonly ILogger<createdegModel> _logger;
        private readonly IDataKonsumenService _dataKonsumenService;
       // private readonly Smm.Contoh.Data.ApplicationDbContext _context;

        public createdegModel(ILogger<createdegModel> logger, IDataKonsumenService dataKonsumenService)
        {
            _logger = logger;
            _dataKonsumenService = dataKonsumenService;
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
            var xx =
            await _dataKonsumenService.AddDataKonsumenAsync(DataKonsumenDto.,);
            //_context.DataKonsumenDto.Add(DataKonsumenDto);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
