using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterBidangPekerjaan: AggregateRoot<Guid>
    {
        protected MasterBidangPekerjaan()
        {

        }
        private MasterBidangPekerjaan(string namaMasterBidangPekerjaan, DateTime? tanggalInput)
        {
            NamaMasterBidangPekerjaan = namaMasterBidangPekerjaan;
            TanggalInput = tanggalInput;
        }
        public static MasterBidangPekerjaan Create(string namaMasterBidangPekerjaan, DateTime? tanggalInput)
        {
            return new MasterBidangPekerjaan(namaMasterBidangPekerjaan,tanggalInput);
        }
        public string NamaMasterBidangPekerjaan { get; private set; }
        public DateTime? TanggalInput { get; private set; }

        public void EditMasterBidangPekerjaan(string namaMasterBidangPekerjaan)
        {
            NamaMasterBidangPekerjaan = namaMasterBidangPekerjaan;
        }
    }
}
