using MediatR;
using Smm.ContohMVCOutboxPattern.DDD.Bus;
using Smm.ContohMVCOutboxPattern.Domain.ValueObject;
using Smm.ContohMVCOutboxPattern.Events;
using Smm.ContohMVCOutboxPattern.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.ServiceApplication.DataKonsumen.Command.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandHandler : IRequestHandler<CreateDataKonsumenCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMediatorHandler Bus;
        public CreateDataKonsumenCommandHandler(ApplicationDbContext dbContext, IMediatorHandler bus)
        {
            _dbContext=dbContext;
            Bus=bus;
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

                await Bus.RaiseEvent(new DataKonsumenRegisteredEvent(dtKonsumen.DataKonsumenId, request.NamaDepan,request.Email));

              //  await _dbContext.SaveChangesAsync();  // dialihkan / digabung savechangesasync di bagian raise event 

                //await _unitOfWork.DataKonsumen.AddAsync(dtKonsumen, cancellationToken);
                //await _unitOfWork.CommitAsync();

            }



            return Unit.Value;
        }
    }
}
