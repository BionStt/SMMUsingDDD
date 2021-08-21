using MediatR;
using Smm.ContohCQRSNoEventSourcing.Data;
using Smm.ContohCQRSNoEventSourcing.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandHandler : IRequestHandler<CreateDataKonsumenCommand>
    {
        private readonly ApplicationDbContext _dbContext;
      //  private readonly IContohCQRSUnitOfWork _unitOfWork;
        public CreateDataKonsumenCommandHandler(ApplicationDbContext dbContext)//, IContohCQRSUnitOfWork unitOfWork)
        {
            _dbContext = dbContext;
          //  _unitOfWork = unitOfWork;
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
                //await _unitOfWork.DataKonsumen.AddAsync(dtKonsumen, cancellationToken);
                //await _unitOfWork.CommitAsync();

                await _dbContext.DataKonsumen.AddAsync(dtKonsumen);
                await _dbContext.SaveEntitiesAsync(cancellationToken);
               // await _dbContext.SaveChangesAsync(cancellationToken);
            }



            return Unit.Value;

        }
    }
}
