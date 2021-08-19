using Smm.ContohMvcCQRS.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Data.Events
{
    public interface IEventSerializer
    {
        string Serialize<TE>(TE @event) where TE : Event;
    }

    public class EventSerializer : IEventSerializer
    {
        public string Serialize<TE>(TE @event) where TE : Event
        {
            if (null == @event)
                throw new ArgumentNullException(nameof(@event));

            var eventType = @event.GetType();
            var result = JsonSerializer.Serialize(@event, eventType);
            return result;
        }
    }
}
