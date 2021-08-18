using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterBidangUsaha : AggregateRoot<Guid>
    {
        protected MasterBidangUsaha()
        {

        }
        private MasterBidangUsaha(string namaMasterBidangUsaha, DateTime tanggalInput)
        {
            NamaMasterBidangUsaha = namaMasterBidangUsaha;
            TanggalInput = tanggalInput;
        }
        public static MasterBidangUsaha Create(string namaMasterBidangUsaha, DateTime tanggalInput)
        {
            return new MasterBidangUsaha(namaMasterBidangUsaha, tanggalInput);
        }
        public string NamaMasterBidangUsaha { get; private set; }
        public DateTime TanggalInput { get; private  set; }

        public void EditMasterBidangUsaha(string namaMasterBidangUsaha)
        {
            NamaMasterBidangUsaha = namaMasterBidangUsaha;
        }
    }
}
