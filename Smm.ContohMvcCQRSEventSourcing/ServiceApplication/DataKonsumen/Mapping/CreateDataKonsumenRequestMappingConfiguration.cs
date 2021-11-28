using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Command.CreateDataKonsumen;
using Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Queries.ListDataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Mapping
{
    public static class CreateDataKonsumenRequestMappingConfiguration
    {
        public static ListDataKonsumenQueryDto ToDto(this ListDataKonsumenQueryResponse response)
        {
            return new ListDataKonsumenQueryDto
            {
                Id = response.Id,
                NomorKTP = response.NomorKTP,
                TanggalLahir = response.TanggalLahir,
                JenisKelamin = response.JenisKelamin,
                Agama = response.Agama,
                NamaDepan = response.NamaDepan,
                NamaBelakang = response.NamaBelakang,
                NamaDepanBPKB = response.NamaDepan,
                NamaBelakangBPKB = response.NamaBelakang,
                JalanTinggal = response.JalanTinggal,
                KelurahanTinggal = response.KelurahanTinggal,
                KecamatanTinggal = response.KecamatanTinggal,
                KotaTinggal = response.KotaTinggal,
                PropinsiTinggal = response.PropinsiTinggal,
                KodePosTinggal = response.KodePosTinggal,
                NoTeleponTinggal = response.NoTeleponTinggal,
                NoFaxTinggal = response.NoFaxTinggal,
                NoHandphoneTinggal = response.NoHandphoneTinggal,

                JalanKirim = response.JalanKirim,
                KelurahanKirim = response.KelurahanKirim,
                KecamatanKirim = response.KecamatanKirim,
                KotaKirim = response.KotaKirim,
                PropinsiKirim = response.PropinsiKirim,
                KodePosKirim = response.KodePosKirim,
                NoTeleponKirim = response.NoTeleponKirim,
                NoFaxKirim = response.NoFaxKirim,
                NoHandphoneKirim = response.NoHandphoneKirim,
                Email = response.Email

            };
        }

        public static CreateDataKonsumenRequest ToRequest(this CreateDataKonsumenCommand command)
        {
            if (command == null)
            {
                return null;
            }

            return new CreateDataKonsumenRequest
            {
                NomorKTP = command.NomorKTP,
                TanggalLahir = command.TanggalLahir,
                JenisKelamin = command.JenisKelamin,
                Agama = command.Agama,
                NamaDepan = command.NamaDepan,
                NamaBelakang = command.NamaBelakang,
                NamaDepanBPKB = command.NamaDepan,
                NamaBelakangBPKB = command.NamaBelakang,
                JalanTinggal = command.JalanTinggal,
                KelurahanTinggal = command.KelurahanTinggal,
                KecamatanTinggal = command.KecamatanTinggal,
                KotaTinggal = command.KotaTinggal,
                PropinsiTinggal = command.PropinsiTinggal,
                KodePosTinggal = command.KodePosTinggal,
                NoTeleponTinggal = command.NoTeleponTinggal,
                NoFaxTinggal = command.NoFaxTinggal,
                NoHandphoneTinggal = command.NoHandphoneTinggal,

                JalanKirim = command.JalanKirim,
                KelurahanKirim = command.KelurahanKirim,
                KecamatanKirim = command.KecamatanKirim,
                KotaKirim = command.KotaKirim,
                PropinsiKirim = command.PropinsiKirim,
                KodePosKirim = command.KodePosKirim,
                NoTeleponKirim = command.NoTeleponKirim,
                NoFaxKirim = command.NoFaxKirim,
                NoHandphoneKirim = command.NoHandphoneKirim,
                Email = command.Email

            };
        }

        public static CreateDataKonsumenCommand ToCommand(this CreateDataKonsumenRequest model)
        {

            return new CreateDataKonsumenCommand
            {
                NomorKTP = model.NomorKTP,
                TanggalLahir = model.TanggalLahir,
                JenisKelamin = model.JenisKelamin,
                Agama = model.Agama,
                NamaDepan = model.NamaDepan,
                NamaBelakang = model.NamaBelakang,
                NamaDepanBPKB = model.NamaDepan,
                NamaBelakangBPKB = model.NamaBelakang,
                JalanTinggal = model.JalanTinggal,
                KelurahanTinggal = model.KelurahanTinggal,
                KecamatanTinggal = model.KecamatanTinggal,
                KotaTinggal = model.KotaTinggal,
                PropinsiTinggal = model.PropinsiTinggal,
                KodePosTinggal = model.KodePosTinggal,
                NoTeleponTinggal = model.NoTeleponTinggal,
                NoFaxTinggal = model.NoFaxTinggal,
                NoHandphoneTinggal = model.NoHandphoneTinggal,

                JalanKirim = model.JalanKirim,
                KelurahanKirim = model.KelurahanKirim,
                KecamatanKirim = model.KecamatanKirim,
                KotaKirim = model.KotaKirim,
                PropinsiKirim = model.PropinsiKirim,
                KodePosKirim = model.KodePosKirim,
                NoTeleponKirim = model.NoTeleponKirim,
                NoFaxKirim = model.NoFaxKirim,
                NoHandphoneKirim = model.NoHandphoneKirim,
                Email = model.Email

            };
        }


    }
}
