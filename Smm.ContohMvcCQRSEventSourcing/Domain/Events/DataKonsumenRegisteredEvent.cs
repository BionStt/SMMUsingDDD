using Smm.ContohMvcCQRSEventSourcing.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.Domain.Events
{
    public class DataKonsumenRegisteredEvent : DomaintEvent
    {
        public DataKonsumenRegisteredEvent(Guid dataKonsumenId, string nama, string email)
        {
            DataKonsumenId = dataKonsumenId;
            Nama = nama;
            AggregateId = dataKonsumenId;
            Email = email;
        }

        public Guid DataKonsumenId { get; private set; }
        public string Nama { get; private set; }
        public string Email { get; private set; }



    }
}
