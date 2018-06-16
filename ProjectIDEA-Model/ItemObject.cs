using System;
using Newtonsoft.Json;

namespace ProjectIDEAModel
{
    [JsonObject]
    public class ItemObject
    {
        [JsonProperty("id")]         public int Id { get; private set; }

        [JsonProperty("song")]
        public SongObject SongObject { get; private set; }

        [JsonProperty("username")]
        public string UserName { get; private set; }

        public ItemObject(int id, SongObject songObject, string userName)
        {
            this.Id = id;
            this.SongObject = songObject;
            this.UserName = userName;
        }
    }
}
