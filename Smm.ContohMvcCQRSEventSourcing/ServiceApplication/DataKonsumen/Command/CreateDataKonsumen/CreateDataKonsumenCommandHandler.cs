using MediatR;
using Smm.ContohMvcCQRSEventSourcing.Domain.ValueObject;
using Smm.ContohMvcCQRSEventSourcing.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.ServiceApplication.DataKonsumen.Command.CreateDataKonsumen
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
            var dtKonsumen = Domain.DataKonsumen.Create(NomorKTP.CreateNoKTP(request.NomorKTP), request.TanggalLahir, request.JenisKelamin, request.Agama,
                Name.CreateName(request.NamaDepan, request.NamaBelakang), Name.CreateName(request.NamaDepanBPKB, request.NamaBelakangBPKB),
                Alamat.CreateAlamat(request.JalanTinggal, request.KelurahanTinggal, request.KecamatanTinggal, request.KotaTinggal, request.PropinsiTinggal,
                request.KodePosTinggal, request.NoTeleponTinggal, request.NoFaxTinggal, request.NoHandphoneTinggal), Alamat.CreateAlamat(request.JalanKirim,
                request.KelurahanKirim, request.KecamatanKirim, request.KotaKirim, request.PropinsiKirim, request.KodePosKirim, request.NoTeleponKirim,
                request.NoFaxKirim, request.NoHandphoneKirim), request.Email);

            if (dtKonsumen != null)
            {
                await _dbContext.DataKonsumen.AddAsync(dtKonsumen);

                await _dbContext.SaveChangesAsync();

                //await _unitOfWork.DataKonsumen.AddAsync(dtKonsumen, cancellationToken);
                //await _unitOfWork.CommitAsync();

            }



            return Unit.Value;

        }
    }
}

