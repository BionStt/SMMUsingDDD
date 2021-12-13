using Smm.ContohMVCOutboxPattern.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Events
{
    public class DataKonsumenRegisteredEvent : DomaintEvent
    {
        public DataKonsumenRegisteredEvent(Guid dataKonsumenId, string nama, string email)
        {
            DataKonsumenId = dataKonsumenId;
            Nama = nama;
            AggregateId = dataKonsumenId;
            DomainId = dataKonsumenId; // mau dicek kembali 
            Email = email;
        }

        public Guid DataKonsumenId { get; private set; }
        public string Nama { get; private set; }
        public string Email { get; private set; }



    }
}
