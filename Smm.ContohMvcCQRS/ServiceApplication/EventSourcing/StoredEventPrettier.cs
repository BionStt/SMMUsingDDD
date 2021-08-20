using Newtonsoft.Json;
using Smm.ContohMvcCQRS.Ddd;
using Smm.ContohMvcCQRS.ServiceApplication.EventSourcing.StoredEventsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.ServiceApplication.EventSourcing
{
    public static class StoredEventPrettier<THistoryData>
       where THistoryData : StoredEventData, new()
    {
        public static List<THistoryData> ToPretty(IList<StoredEvent> messages)
        {
            List<THistoryData> historyData = new List<THistoryData>();

            foreach (var message in messages)
            {
                var eventName = message.MessageType
                    .Substring(message.MessageType.LastIndexOf('.')).Substring(1);

                THistoryData history = JsonConvert
                    .DeserializeObject<THistoryData>(message.Payload);

                history.Id = message.Id.ToString();
                history.Timestamp = message
                    .CreatedAt.ToString("yyyy'-'MM'-'dd' - 'HH':'mm':'ss");
                history.Action = eventName;
                historyData.Add(history);
            }

            return historyData;
        }
    }
}
