using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh.IdentityRazor.Helper
{
    public class CrudViewModel<T> where T : class
    {
        public string action { get; set; }
        public object key { get; set; }
        public string antiForgery { get; set; }
        public T value { get; set; }
    }
}
