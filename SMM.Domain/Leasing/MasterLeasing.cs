using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterLeasing:AggregateRoot<Guid>
    {
        protected MasterLeasing()
        {

        }
        public string NamaLeasing { get; private set; }

        private readonly List<MasterLeasingCabang> _listCabangs = new List<MasterLeasingCabang>();
        public IReadOnlyCollection<MasterLeasingCabang> MasterLeasingCabangs => _listCabangs;
        public static MasterLeasing Create(string namaLeasing)
        {
            var masterLeasing = new MasterLeasing();
            masterLeasing.NamaLeasing = namaLeasing;
            masterLeasing.Id = Guid.NewGuid();
            return masterLeasing;

        }
        public MasterLeasingCabang AddCabangLeasing(string namaCabang, Guid masterLeasingId, string emailCabang, Alamat alamatCabangLeasing)
        {
            var listCabangLeasing = MasterLeasingCabang.Create(namaCabang,emailCabang,alamatCabangLeasing);
            _listCabangs.Add(listCabangLeasing);
            return listCabangLeasing;

        }

        public MasterLeasingCabang EditCabangLeasing(Guid masterCabangLeasingId, string namaCabang, string emailCabang, Alamat alamatCabangLeasing)
        {
            var _listCabangLeasing = _listCabangs.FirstOrDefault(i => i.Id == masterCabangLeasingId);
            _listCabangLeasing.EditMasterLeasingCabang(namaCabang,emailCabang,alamatCabangLeasing);
            return _listCabangLeasing;
        }
        public MasterLeasingCabang CabangLeasingDiNonAktifkan(Guid masterCabangLeasingId)
        {
            var _listCabangLeasing = _listCabangs.FirstOrDefault(i => i.Id == masterCabangLeasingId);
            _listCabangLeasing.MarkAsNonAktif();
            return _listCabangLeasing;
        }
    }

}
