using System;
using Newtonsoft.Json;

namespace ProjectIDEAModel
{
    [JsonObject]
    public class Song
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        public Song(int id, string url)
        {
            this.Id = id;
            this.Url = url;
        }
    }
}