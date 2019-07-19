using System;
using Newtonsoft.Json;

namespace Altazion.Api.Events
{
    public static class EventHandling
    {

        public static bool TryDeserialize<T>(string data, string eventCategory, string eventKind, out T retValue) where T : class, new()
        {
            if (string.IsNullOrEmpty(eventCategory))
                throw new ArgumentException("Category should not be null", nameof(eventCategory));
            if (string.IsNullOrEmpty(eventKind))
                throw new ArgumentException("Kind should not be null", nameof(eventKind));

            retValue = null;

            var dt = JsonConvert.DeserializeObject<EventRootData<T>>(data);

            if(dt!=null)
            {
                if (eventCategory.Equals(dt.EventCategory, StringComparison.InvariantCultureIgnoreCase)
                    && eventKind.Equals(dt.EventKind, StringComparison.InvariantCultureIgnoreCase))
                {
                    retValue = dt.Data;
                    return true;
                }
            }
            return false;
        }


        private class EventRootData<T> where T:class, new()
        {
            public string EventKind { get; set; }
            public string EventCategory { get; set; }
            public T Data { get; set; }
        }


    }
}
