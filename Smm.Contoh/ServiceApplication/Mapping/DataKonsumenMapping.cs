using Smm.Contoh.Domain;
using Smm.Contoh.Domain.ValueObject;
using Smm.Contoh.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.ServiceApplication.Mapping
{
    public static class DataKonsumenMapping
    {
        public static DataKonsumen ToEntity(this DataKonsumenDto model)
        {
            var xx = DataKonsumen.Create(new NomorKTP(model.NomorKTP),model.TanggalLahir,model.JenisKelamin,new Name(model.NamaDepan,model.NamaBelakang),new Name(model.NamaDepanBPKB,model.NamaBelakangBPKB),
                new Alamat(model.JalanTinggal,model.KelurahanTinggal,model.KecamatanTinggal,model.KotaTinggal,model.PropinsiTinggal,model.KodePosTinggal,model.NoTeleponTinggal,model.NoFaxTinggal,model.NoHandphoneTinggal),
                new Alamat(model.JalanKirim,model.KelurahanKirim,model.KecamatanKirim,model.KotaKirim,model.PropinsiKirim,model.KodePosKirim,model.NoTeleponKirim,model.NoFaxKirim,model.NoHandphoneKirim));
            return xx;
            //return new DataKonsumen
            //{

            //    NoKTP = model.NomorKTP,
            //    TanggalLahir = model.TanggalLahir,
            //    JenisKelamin = model.JenisKelamin,
            //    Agama = model.Agama,
            //    NamaDepan = model.NamaDepan,
            //    NamaBelakang = model.NamaBelakang,
            //    NamaDepanBPKB = model.NamaDepan,
            //    NamaBelakangBPKB = model.NamaBelakang,
            //    JalanTinggal = model.JalanTinggal,
            //    KelurahanTinggal = model.KelurahanTinggal,
            //    KecamatanTinggal = model.KecamatanTinggal,
            //    KotaTinggal = model.KotaTinggal,
            //    PropinsiTinggal = model.PropinsiTinggal,
            //    KodePosTinggal = model.KodePosTinggal,
            //    NoTeleponTinggal = model.NoTeleponTinggal,
            //    NoFaxTinggal = model.NoFaxTinggal,
            //    NoHandphoneTinggal = model.NoHandphoneTinggal,

            //    JalanKirim = model.JalanKirim,
            //    KelurahanKirim = model.KelurahanKirim,
            //    KecamatanKirim = model.KecamatanKirim,
            //    KotaKirim = model.KotaKirim,
            //    PropinsiKirim = model.PropinsiKirim,
            //    KodePosKirim = model.KodePosKirim,
            //    NoTeleponKirim = model.NoTeleponKirim,
            //    NoFaxKirim = model.NoFaxKirim,
            //    NoHandphoneKirim = model.NoHandphoneKirim,
            //    Email = model.Email

            //};
        }
    }
}
