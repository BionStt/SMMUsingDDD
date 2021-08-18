using Smm.Contoh2.Domain;
using Smm.Contoh2.Domain.ValueObject;
using Smm.ContohMVC.Domain.EnumInEntity;
using Smm.ContohMVC.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh2.ServiceApplication
{
    public class DataKonsumenService : IDataKonsumenService
    {
        private readonly IContohUnitOfWork _repo;

        public DataKonsumenService(IContohUnitOfWork repo)
        {
            _repo = repo;
        }

        private readonly Expression<Func<Agama, AgamaDto>> _AgamaSelector = c => new()
        {
                    Id = c.Id,
                    AgamaKeterangan = c.AgamaKeterangan

        };

        private readonly Expression<Func<JenisKelamin, JenisKelaminDto>> _JenisKelaminSelector = c => new()
        {
            Id = c.Id,
            JenisKelaminKeterangan = c.JenisKelaminKeterangan

        };
        private readonly Expression<Func<DataKonsumen, ListDataKonsumenDto>> _ListDataKonsumenSelector = c => new()
        {
            Id = c.Id,
            NomorKTP = c.NoKTP.Value,
            TanggalLahir = c.TanggalLahir,
            JenisKelamin =c.JenisKelamin,
            Agama=c.Agama,
            NamaDepan= c.Nama.NamaDepan,
            NamaBelakang = c.Nama.NamaBelakang,
            NamaDepanBPKB = c.NamaBPKB.NamaDepan,
            NamaBelakangBPKB = c.NamaBPKB.NamaBelakang,
            JalanTinggal = c.AlamatTinggal.Jalan,
            KelurahanTinggal = c.AlamatTinggal.Kelurahan,
            KecamatanTinggal = c.AlamatTinggal.Kecamatan,
            KotaTinggal = c.AlamatTinggal.Kota,
            PropinsiTinggal = c.AlamatTinggal.Propinsi,
            KodePosTinggal = c.AlamatTinggal.KodePos,
            NoTeleponTinggal = c.AlamatTinggal.NoTelepon,
            NoFaxTinggal = c.AlamatTinggal.NoFax,
            NoHandphoneTinggal = c.AlamatTinggal.NoHandphone,

            JalanKirim = c.AlamatKirim.Jalan,
            KelurahanKirim = c.AlamatKirim.Kelurahan,
            KecamatanKirim = c.AlamatKirim.Kecamatan,
            KotaKirim = c.AlamatKirim.Kota,
            PropinsiKirim = c.AlamatKirim.Propinsi,
            KodePosKirim = c.AlamatKirim.KodePos,
            NoTeleponKirim = c.AlamatKirim.NoTelepon,
            NoFaxKirim = c.AlamatKirim.NoFax,
            NoHandphoneKirim = c.AlamatKirim.NoHandphone,
            Email = c.Email


        };

        public async Task AddDataKonsumenAsync(string nomorKTP,DateTime tanggalLahir,string jenisKelamin,string agama,string namaDepan,string namaBelakang,string namaDepanBPKB,string namaBelakangBPKB,
            string jalanTinggal,string kelurahanTinggal,string kecamatanTinggal,string kotaTinggal,string propinsiTinggal,string kodeposTinggal,string noTeleponTinggal,string noFaxTinggal,string noHandphoneTinggal,
            string jalanKirim,string kelurahanKirim,string kecamatanKirim,string kotaKirim,string propinsiKirim,string kodeposKirim,string noTeleponKirim,string noFaxKirim,string noHandphoneKirim,string email)
        {
           var DataKonsumenBaru = DataKonsumen.Create(NomorKTP.CreateNoKTP(nomorKTP), tanggalLahir, jenisKelamin,agama,
                Name.CreateName(namaDepan, namaBelakang), Name.CreateName(namaDepanBPKB, namaBelakangBPKB),
                Alamat.CreateAlamat(jalanTinggal, kelurahanTinggal, kecamatanTinggal, kotaTinggal, propinsiTinggal, kodeposTinggal, noTeleponTinggal, noFaxTinggal, noHandphoneTinggal),
                Alamat.CreateAlamat(jalanKirim, kelurahanKirim, kecamatanKirim, kotaKirim, propinsiKirim, kodeposKirim, noTeleponKirim, noFaxKirim, noHandphoneKirim),email);

            await _repo.DataKonsumenRepository.AddAsync(DataKonsumenBaru);
            await _repo.CommitAsync();

        }

        public async Task<IReadOnlyList<AgamaDto>> GetListAgama()
        {
            return await _repo.AgamaRepository.GetAllAgamaAsync(_AgamaSelector);

        }

        public async Task<IReadOnlyList<JenisKelaminDto>> GetListJenisKelamin()
        {
            return await _repo.JenisKelaminRepository.GetAllJenisKelaminAsync(_JenisKelaminSelector);
        }

        public async Task<IReadOnlyList<ListDataKonsumenDto>> GetListDataKonsumen()
        {
            return await _repo.DataKonsumenRepository.ListDataKonsumenAsync(_ListDataKonsumenSelector);
        }
    }
}
