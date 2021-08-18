using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterLeasingCabang:Entity<Guid>
    {

        public string NamaCabang { get; private set; }
        public string EmailCabang { get; private set; }
        public LeasingCabangStatus Status { get; private set; }

        public Alamat AlamatCabangLeasing { get; private set; }

        public Guid MasterLeasingId { get; private set; }
        public MasterLeasing MasterLeasing { get; private set; }
        protected MasterLeasingCabang()
        {

        }
        public static MasterLeasingCabang Create(string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            return new MasterLeasingCabang(namaCabang,  emailCabang, alamatCabangLeasing);
        }

        private MasterLeasingCabang(string namaCabang,string emailCabang, Alamat alamatCabangLeasing)
        {
            Id = Guid.NewGuid();
           // MasterLeasingId = masterLeasingId;
            NamaCabang = namaCabang;
            EmailCabang = emailCabang;
            Status = LeasingCabangStatus.Aktif;
            AlamatCabangLeasing = alamatCabangLeasing;
        }
        public void EditMasterLeasingCabang(string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            NamaCabang = namaCabang;
            EmailCabang = emailCabang;
            AlamatCabangLeasing = alamatCabangLeasing;
        }

        public void MarkAsNonAktif()
        {
            Status = LeasingCabangStatus.TidakAktif;

        }
    }
    public enum LeasingCabangStatus
    {
        TidakAktif=0,
        Aktif=1
    }
}
