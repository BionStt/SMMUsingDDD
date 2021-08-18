using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterKategoriCaraPembayaran: AggregateRoot<Guid>
    {
        protected MasterKategoriCaraPembayaran()
        {

        }
        private MasterKategoriCaraPembayaran(string caraPembayaran)
        {
            CaraPembayaran = caraPembayaran;
        }
        public static MasterKategoriCaraPembayaran Create(string caraPembayaran)
        {
            return new MasterKategoriCaraPembayaran(caraPembayaran);
        }

        public string CaraPembayaran { get; private set; }
        public void EditMasterKategoriCaraPembayaran(string caraPembayaran)
        {
            CaraPembayaran = caraPembayaran;
        }
    }
}
