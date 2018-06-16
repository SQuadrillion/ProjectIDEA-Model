using System;
using Newtonsoft.Json;

namespace ProjectIDEAModel
{
    [JsonObject]
    public class QueueItem
    {
        [JsonProperty("id")]         public int Id { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("time")]
        public string Time { get; private set; }

        [JsonProperty("name")]
        public string Name { get;  private set;}
        
        public QueueItem(int id, string url, string time, string name)
        {
            this.Id = id;
            this.Url = url;
            this.Time = time;
            this.Name = name;
        }
    }
}
