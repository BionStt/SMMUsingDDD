using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Smm.ContohRazor.Data;

namespace Smm.ContohRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Smm.ContohRazor.Data.ApplicationDbContext _context;

        public IndexModel(Smm.ContohRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<DataKonsumen> DataKonsumen { get;set; }

        public async Task OnGetAsync()
        {
            DataKonsumen = await _context.DataKonsumen.ToListAsync();
        }
    }
}
