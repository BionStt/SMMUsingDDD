using MediatR;
using Smm.ContohMvcCQRS.Data;
using Smm.ContohMvcCQRS.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandHandler : IRequestHandler<CreateDataKonsumenCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        public CreateDataKonsumenCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(CreateDataKonsumenCommand request, CancellationToken cancellationToken)
        {
            var xx = Domain.DataKonsumen.Create(NomorKTP.CreateNoKTP(request.NomorKTP), request.TanggalLahir, request.JenisKelamin, request.Agama,
                Name.CreateName(request.NamaDepan, request.NamaBelakang), Name.CreateName(request.NamaDepanBPKB, request.NamaBelakangBPKB),
                Alamat.CreateAlamat(request.JalanTinggal, request.KelurahanTinggal, request.KecamatanTinggal, request.KotaTinggal, request.PropinsiTinggal,
                request.KodePosTinggal, request.NoTeleponTinggal, request.NoFaxTinggal, request.NoHandphoneTinggal), Alamat.CreateAlamat(request.JalanKirim,
                request.KelurahanKirim, request.KecamatanKirim, request.KotaKirim, request.PropinsiKirim, request.KodePosKirim, request.NoTeleponKirim,
                request.NoFaxKirim, request.NoHandphoneKirim), request.Email);

             await _dbContext.DataKonsumen.AddAsync(xx);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
