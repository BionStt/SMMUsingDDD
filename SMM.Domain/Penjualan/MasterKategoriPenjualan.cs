using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterKategoriPenjualan: AggregateRoot<Guid>
    {
        protected MasterKategoriPenjualan()
        {

        }
        private MasterKategoriPenjualan(string namaKategoryPenjualan)
        {
            NamaKategoryPenjualan = namaKategoryPenjualan;
        }
        public static MasterKategoriPenjualan Create(string namaKategoryPenjualan)
        {
            return new MasterKategoriPenjualan(namaKategoryPenjualan);
        }
        public string NamaKategoryPenjualan { get; private set; }

        public void EditMasterKategoriPenjualan(string namaKategoryPenjualan)
        {
            NamaKategoryPenjualan = namaKategoryPenjualan;
        }
    }
}
