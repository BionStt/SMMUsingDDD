using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.ServiceApplication.EventSourcing.StoredEventsData
{
    public class CustomerStoredEventData : StoredEventData
    {
        public string Name { get; set; }
    }
}
