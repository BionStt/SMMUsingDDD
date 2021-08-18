
using Smm.ContohMVC.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh2.ServiceApplication
{
    public interface IDataKonsumenService
    {
        // Task AddDataKonsumenAsync(CreateDataKonsumenDto NewDataKonsumen);
        Task AddDataKonsumenAsync(string nomorKTP, DateTime tanggalLahir, string jenisKelamin, string agama, string namaDepan, string namaBelakang, string namaDepanBPKB, string namaBelakangBPKB,
            string jalanTinggal, string kelurahanTinggal, string kecamatanTinggal, string kotaTinggal, string propinsiTinggal, string kodeposTinggal, string noTeleponTinggal, string noFaxTinggal, string noHandphoneTinggal,
            string jalanKirim, string kelurahanKirim, string kecamatanKirim, string kotaKirim, string propinsiKirim, string kodeposKirim, string noTeleponKirim, string noFaxKirim, string noHandphoneKirim, string email);
        Task<IReadOnlyList<ListDataKonsumenDto>> GetListDataKonsumen();
        Task<IReadOnlyList<JenisKelaminDto>> GetListJenisKelamin();

        Task<IReadOnlyList<AgamaDto>> GetListAgama();


    }
}
