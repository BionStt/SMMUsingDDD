using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.DataSPK

{
    public class DataSPK:AggregateRoot<Guid>
    {

        public string NoRegistrasiSPK { get; private set; }
        public string LokasiSpk { get; set; }
        public StatusSPK StatusSPK { get; private set; }

        public Guid UserInput { get; private set; }

        public DateTime TanggalInput { get; private set; }

        private readonly List<DataSPKSurvei> _dataSpkSurvei = new List<DataSPKSurvei>();
        public IReadOnlyCollection<DataSPKSurvei> DataSPKSurvei => _dataSpkSurvei;

        private readonly List<DataSPKKendaraan> _dataSpkKendaraan = new List<DataSPKKendaraan>();
        public IReadOnlyCollection<DataSPKKendaraan> DataSPKKendaraan => _dataSpkKendaraan;

        private readonly List<DataSPKLeasing> _dataSpkLeasing = new List<DataSPKLeasing>();
        public IReadOnlyCollection<DataSPKLeasing> DataSPKLeasing => _dataSpkLeasing;




        public DataSPKSurvei AddDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            var dataSPKSurvei = new DataSPKSurvei(noKTPPemesan,namaPemesan,alamatPemesan,dataNPWPPemesan,pekerjaanPemesan);
            _dataSpkSurvei.Add(dataSPKSurvei);
            return dataSPKSurvei;
        }

        public DataSPKSurvei EditDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan,Guid DataSpkSurveiId)
        {
            var dataSPKSurvei = _dataSpkSurvei.FirstOrDefault(i => i.Id == DataSpkSurveiId);
            dataSPKSurvei.EditDataSPKSurvei(noKTPPemesan,namaPemesan,alamatPemesan,dataNPWPPemesan,pekerjaanPemesan);
            return dataSPKSurvei;
        }

        private readonly List<DataSPKKredit> _dataSpkKredit = new List<DataSPKKredit>();
        public IReadOnlyCollection<DataSPKKredit> DataSPKKredit => _dataSpkKredit;
        public DataSPKKredit AddDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit)
        {
            var dataSPKKredit = new DataSPKKredit(biayaAdministrasiKredit,biayaAdministrasiTunai,bBN,dendaWilayah,diskonDP,diskonTunai,dPPriceList,komisi,offTheRoad,promosi,uangTandaJadiTunai,uangTandaJadiKredit);
            _dataSpkKredit.Add(dataSPKKredit);
            return dataSPKKredit;
        }
        public DataSPKKredit EditDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit , Guid DataSpkKreditId)
        {
            var dataspkKredit = _dataSpkKredit.FirstOrDefault(i => i.Id == DataSpkKreditId);
            dataspkKredit.EditDataSPKKredit(biayaAdministrasiKredit,biayaAdministrasiTunai,bBN,dendaWilayah,diskonDP,diskonTunai,dPPriceList,komisi,offTheRoad,promosi,uangTandaJadiTunai,uangTandaJadiKredit);
            return dataspkKredit;

        }
        public DataSPKLeasing AddDataSPKLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei)
        {
            var dataSpkLeasing = new DataSPKLeasing(angsuran,mediator,namaCmo,namaSales,tenor,tanggalSurvei);
            _dataSpkLeasing.Add(dataSpkLeasing);
            return dataSpkLeasing;
        }
        public DataSPKLeasing EditDataSpkLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei,Guid DataSPKLEasingId)
        {
            var dataSpkLeasing = _dataSpkLeasing.FirstOrDefault(i => i.Id ==DataSPKLEasingId);
            dataSpkLeasing.EditDataSpkLeasing(angsuran,mediator,namaCmo,namaSales,tenor,tanggalSurvei);
            return dataSpkLeasing;
        }

        public DataSPKKendaraan AddDataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK)
        {
            var dataSpkKendaraan = new DataSPKKendaraan(tahunPerakitan,warna,namaSTNK,noKtpSTNK);
            _dataSpkKendaraan.Add(dataSpkKendaraan);
            return dataSpkKendaraan;
        }
        public DataSPKKendaraan EditDataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK,Guid dataspkKendaraanId)
        {
            var dataSPKKendaraan = _dataSpkKendaraan.FirstOrDefault(i => i.Id == dataspkKendaraanId);
            dataSPKKendaraan.EditDataSPKKendaraan(tahunPerakitan,warna,namaSTNK,noKtpSTNK);
            return dataSPKKendaraan;
        }

        public DataSPK(string noRegistrasiSPK, string lokasiSpk, StatusSPK statusSPK, Guid userInput)
        {
            Id = Guid.NewGuid();
            NoRegistrasiSPK = noRegistrasiSPK;
            LokasiSpk = lokasiSpk;
            StatusSPK = statusSPK;
            UserInput = userInput;
        }
        public void EditDataSPK(string noRegistrasiSPK, string lokasiSpk, StatusSPK statusSPK, Guid userInput)
        {
            NoRegistrasiSPK = noRegistrasiSPK;
            LokasiSpk = lokasiSpk;
            StatusSPK = statusSPK;
            UserInput = userInput;
        }

        protected DataSPK()
        {

        }
    }
    public enum StatusSPK
    {
        Disurvei=0,
        DiAcc=1,
        Ditolaks=2
    }
}
