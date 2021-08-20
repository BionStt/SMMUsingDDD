using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Smm.ContohMvcCQRS.Domain.Events;
using Smm.ContohMvcCQRS.ServiceApplication.DomaintEventConfiguration;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenNotification: DomainNotificationBase<DataKonsumenRegisteredEvent>
    {
        public CreateDataKonsumenNotification(DataKonsumenRegisteredEvent domainEvent) : base(domainEvent)
        {
            DataKonsumenId = domainEvent.DataKonsumenId;
            Nama = domainEvent.Nama;
        }

        [JsonConstructor]
        public CreateDataKonsumenNotification(Guid dataKonsumenId, string nama):base(null)
        {
            DataKonsumenId = dataKonsumenId;
            Nama = nama;
        }

        public Guid DataKonsumenId { get;  set; }
        public string Nama { get;  set; }



    }
}
