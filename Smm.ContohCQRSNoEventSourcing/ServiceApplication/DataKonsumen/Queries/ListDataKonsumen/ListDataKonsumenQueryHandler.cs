using MediatR;
using Microsoft.EntityFrameworkCore;
using Smm.ContohCQRSNoEventSourcing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.DataKonsumen.Queries.ListDataKonsumen
{
    public class ListDataKonsumenQueryHandler : IRequestHandler<ListDataKonsumenQuery, List<ListDataKonsumenQueryResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListDataKonsumenQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<ListDataKonsumenQueryResponse>> Handle(ListDataKonsumenQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = _dbContext.DataKonsumen.Select(x => new ListDataKonsumenQueryResponse
            {
                Id = x.Id,
                NomorKTP = x.NoKTP.Value,
                TanggalLahir = x.TanggalLahir,
                JenisKelamin = x.JenisKelamin,
                Agama = x.Agama,
                NamaDepan = x.Nama.NamaDepan,
                NamaBelakang = x.Nama.NamaBelakang,
                NamaDepanBPKB = x.NamaBPKB.NamaDepan,
                NamaBelakangBPKB = x.NamaBPKB.NamaBelakang,
                JalanTinggal = x.AlamatTinggal.Jalan,
                KelurahanTinggal = x.AlamatTinggal.Kelurahan,
                KecamatanTinggal = x.AlamatTinggal.Kecamatan,
                KotaTinggal = x.AlamatTinggal.Kota,
                PropinsiTinggal = x.AlamatTinggal.Propinsi,
                KodePosTinggal = x.AlamatTinggal.KodePos,
                NoTeleponTinggal = x.AlamatTinggal.NoTelepon,
                NoFaxTinggal = x.AlamatTinggal.NoFax,
                NoHandphoneTinggal = x.AlamatTinggal.NoHandphone,
                JalanKirim = x.AlamatKirim.Jalan,
                KelurahanKirim = x.AlamatKirim.Kelurahan,
                KecamatanKirim = x.AlamatKirim.Kecamatan,
                KotaKirim = x.AlamatKirim.Kota,
                PropinsiKirim = x.AlamatKirim.Propinsi,
                KodePosKirim = x.AlamatKirim.KodePos,
                NoTeleponKirim = x.AlamatKirim.NoTelepon,
                NoFaxKirim = x.AlamatKirim.NoFax,
                NoHandphoneKirim = x.AlamatKirim.NoHandphone,
                Email = x.Email


            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
