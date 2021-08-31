using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Smm.Contoh.Data;
using Smm.Contoh.ServiceApplication;
using Smm.Contoh.ServiceApplication.Dto;

namespace Smm.Contoh.Pages.DataKonsumen
{
    public class ListDataKonsumenModel : PageModel
    {
        private readonly ILogger<createdegModel> _logger;
        private readonly IDataKonsumenService _dataKonsumenService;


        public ListDataKonsumenModel(ILogger<createdegModel> logger, IDataKonsumenService dataKonsumenService)
        {
            _logger = logger;
            _dataKonsumenService = dataKonsumenService;
        }

        public IReadOnlyList<ListDataKonsumenDto> ListDataKonsumenDto { get;set; }

        public async Task OnGetAsync( )
        {
            ListDataKonsumenDto = await _dataKonsumenService.GetListDataKonsumen();
          //  return Page();
        }
    }
}
