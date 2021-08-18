using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterSupplier:AggregateRoot<Guid>
    {
        protected MasterSupplier()
        {

        }

        public MasterSupplierStatus MasterSupplierStatus { get; private set; }
        public string NamaSupplier { get; private set; }

        public Alamat AlamatSupplier { get; private set; }

        private MasterSupplier(string namaSupplier, Alamat alamatSupplier)
        {
            MasterSupplierStatus = MasterSupplierStatus.Aktif;
            NamaSupplier = namaSupplier;
            AlamatSupplier = alamatSupplier;
        }
        public static MasterSupplier Create(string namaSupplier, Alamat alamatSupplier)
        {
            return new MasterSupplier(namaSupplier,alamatSupplier);
        }
        public void EditMasterSupplier(string namaSupplier, Alamat alamatSupplier)
        {
            NamaSupplier = namaSupplier;
            AlamatSupplier = alamatSupplier;
        }
        public void NonAktifkanMasterSupplier()
        {
            MasterSupplierStatus = MasterSupplierStatus.TidakAktif;
        }
    }
    public enum MasterSupplierStatus
    {
        TidakAktif = 0,
        Aktif = 1
    }
}
