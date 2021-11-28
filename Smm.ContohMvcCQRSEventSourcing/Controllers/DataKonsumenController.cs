﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.Agama.Queries.AgamaList;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Command.CreateDataKonsumen;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Mapping;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Queries.ListDataKonsumen;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.JenisKelamin.Queries.JenisKelaminList;

namespace Smm.ContohMvcCQRSEventSourcing.Controllers
{
    public class DataKonsumenController : Controller
    {
        private readonly ILogger<DataKonsumenController> _logger;
        private readonly IMediator _mediator;

        public DataKonsumenController(ILogger<DataKonsumenController> logger, IMediator mediator)
        {
            _logger=logger;
            _mediator=mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListDataKonsumen()
        {

            var ListDtKonsumen = await _mediator.Send(new ListDataKonsumenQuery());

            return View(ListDtKonsumen);

        }

        [HttpGet]
        public async Task<IActionResult> CreateDataKonsumen()
        {

            var Agama = await _mediator.Send(new AgamaListQuery());
            ViewData["Agama"] = new SelectList(Agama, "Id", "AgamaKeterangan");

            var JenisKelamin = await _mediator.Send(new JenisKelaminListQuery());
            ViewData["JenisKelamin"] = new SelectList(JenisKelamin, "Id", "JenisKelaminKeterangan");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDataKonsumen(CreateDataKonsumenRequest model)
        {
            var DataKonsumen = model.ToCommand();
            await _mediator.Send(DataKonsumen);
            //  return RedirectToAction(nameof(DataKonsumenController.ListDataKonsumen), "ListDataKonsumen");
            return RedirectToAction(nameof(ListDataKonsumen));
            // return View();


        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
