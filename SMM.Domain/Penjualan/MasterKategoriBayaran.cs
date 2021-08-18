using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SMM.Domain
{
    public class MasterKategoriBayaran : AggregateRoot<Guid>
    {
        protected MasterKategoriBayaran()
        {

        }
        private MasterKategoriBayaran(string namaKategoryBayaran)
        {
            NamaKategoryBayaran = namaKategoryBayaran;
        }
        public static MasterKategoriBayaran Create(string namaKategoryBayaran)
        {
            return new MasterKategoriBayaran(namaKategoryBayaran);
        }
        public string NamaKategoryBayaran { get; set; }

        public void EditMasterKategoriBayaran(string namaKategoryBayaran)
        {
            NamaKategoryBayaran = namaKategoryBayaran;
        }
    }
}
