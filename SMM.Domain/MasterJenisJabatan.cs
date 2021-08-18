using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class MasterJenisJabatan:Entity<Guid>
    {
        private MasterJenisJabatan(string namaJabatan)
        {
            NamaJabatan = namaJabatan;
        }
        public static MasterJenisJabatan Create(string namaJabatan)
        {
            return new MasterJenisJabatan(namaJabatan);
        }
        public string NamaJabatan { get; private set; }
        public void EditMasterJenisJabatan(string namaJabatan)
        {
            NamaJabatan = namaJabatan;
        }

    }
}
