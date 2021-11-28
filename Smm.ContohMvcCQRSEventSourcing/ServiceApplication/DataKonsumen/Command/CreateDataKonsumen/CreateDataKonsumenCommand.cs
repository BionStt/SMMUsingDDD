using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Command.CreateDataKonsumen
{
    public class CreateDataKonsumenCommand : IRequest
    {
        public string NomorKTP { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string Agama { get; set; }

        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string NamaDepanBPKB { get; set; }
        public string NamaBelakangBPKB { get; set; }
        public string JalanTinggal { get; set; }
        public string KelurahanTinggal { get; set; }
        public string KecamatanTinggal { get; set; }
        public string KotaTinggal { get; set; }
        public string PropinsiTinggal { get; set; }
        public string KodePosTinggal { get; set; }
        public string NoTeleponTinggal { get; set; }
        public string NoFaxTinggal { get; set; }
        public string NoHandphoneTinggal { get; set; }
        public string JalanKirim { get; set; }
        public string KelurahanKirim { get; set; }
        public string KecamatanKirim { get; set; }
        public string KotaKirim { get; set; }
        public string PropinsiKirim { get; set; }
        public string KodePosKirim { get; set; }
        public string NoTeleponKirim { get; set; }
        public string NoFaxKirim { get; set; }
        public string NoHandphoneKirim { get; set; }
        public string Email { get; set; }
    }
}
