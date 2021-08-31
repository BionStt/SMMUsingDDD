using Smm.Contoh.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Smm.Contoh.ServiceApplication.Dto;
using System.Linq.Expressions;

namespace Smm.Contoh.ServiceApplication
{
    public class DataKonsumenService : IDataKonsumenService
    {
        private readonly IContohUnitOfWork _repo;

        public DataKonsumenService(IContohUnitOfWork repo)
        {
            _repo = repo;
        }

        public async Task AddDataKonsumenAsync(DataKonsumen NewDataKonsumen,CancellationToken cancellationToken)
        {
            var xx = NewDataKonsumen;
             await _repo.DataKonsumenRepository.AddAsync(xx,cancellationToken);

            await _repo.CommitAsync();
        }

        public async Task<IReadOnlyList<ListDataKonsumenDto>> GetListDataKonsumen()
        {
            return await _repo.DataKonsumenRepository.ListDataKonsumenAsync(_ListDataKonsumenSelector);
        }



        private readonly Expression<Func<DataKonsumen, ListDataKonsumenDto>> _ListDataKonsumenSelector = c => new()
        {
            Id = c.Id,
            NomorKTP = c.NoKTP.Value,
            TanggalLahir = c.TanggalLahir,
            JenisKelamin = c.JenisKelamin,
            Agama = c.Agama,
            NamaDepan = c.Nama.NamaDepan,
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
    }
}
