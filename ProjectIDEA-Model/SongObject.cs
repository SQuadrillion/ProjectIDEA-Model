using System;
using Newtonsoft.Json;

namespace ProjectIDEAModel
{
    [JsonObject]
    public class SongObject
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("song_name")]
        public string SongName { get; private set; }

        [JsonProperty("artist_name")]
        public string ArtistName { get; private set; }

        [JsonProperty("artwork_url")]
        public string ArtworkUrl { get; private set; }

        [JsonProperty("time")]
        public string Time { get; private set; }

        [JsonProperty("music_url")]
        public string MusicUrl { get; private set; }

        public SongObject(int id, string songName, string artistName, string artworkUrl, string time, string musicUrl)
        {
            this.Id = id;
            this.SongName = songName;
            this.ArtistName = artistName;
            this.ArtworkUrl = artworkUrl;
            this.Time = time;
            this.MusicUrl = musicUrl;
        }
    }
}