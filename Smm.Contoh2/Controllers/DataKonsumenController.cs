using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Smm.Contoh2.ServiceApplication;
using Smm.ContohMVC.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smm.Contoh2.Controllers
{
    public class DataKonsumenController : Controller
    {
        private readonly ILogger<DataKonsumenController> _logger;
        private readonly IDataKonsumenService _dataKonsumenService;

        public DataKonsumenController(ILogger<DataKonsumenController> logger, IDataKonsumenService dataKonsumenService)
        {
            _logger = logger;
            _dataKonsumenService = dataKonsumenService;
        }

        [HttpGet]
        public async Task<IActionResult> ListDataKonsumen()
        {

            var ListDtKonsumen = await _dataKonsumenService.GetListDataKonsumen();
            return View(ListDtKonsumen);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDataKonsumen()
        {


            var Agama = await _dataKonsumenService.GetListAgama();
            ViewData["Agama"] = new SelectList(Agama, "Id", "AgamaKeterangan");

            var JenisKelamin = await _dataKonsumenService.GetListJenisKelamin();
            ViewData["JenisKelamin"] = new SelectList(JenisKelamin, "Id", "JenisKelaminKeterangan");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKonsumen(CreateDataKonsumenDto model)
        {
                  await _dataKonsumenService.AddDataKonsumenAsync(model.NomorKTP,model.TanggalLahir,model.JenisKelamin,model.Agama,model.NamaDepan,model.NamaBelakang,model.NamaDepanBPKB,model.NamaBelakangBPKB,
                model.JalanTinggal,model.KelurahanTinggal,model.KecamatanTinggal,model.KotaTinggal,model.PropinsiTinggal,model.KodePosTinggal,model.NoTeleponTinggal,model.NoFaxTinggal,model.NoHandphoneTinggal,model.JalanKirim,
                model.KelurahanKirim, model.KecamatanKirim, model.KotaKirim, model.PropinsiKirim, model.KodePosKirim, model.NoTeleponKirim, model.NoFaxKirim, model.NoHandphoneKirim, model.Email);

            return RedirectToAction(nameof(ListDataKonsumen));
            // return View(model);
            // return Ok();
            //  return await _dataKonsumenService.AddDataKonsumenAsync(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
