using System; using System.Net.Http; using Newtonsoft.Json; using System.Threading.Tasks; using System.Collections.Generic; using System.Text; using System.Linq; 
namespace ProjectIDEAModel
{
    public class IdeaRemote
    {
        string URL = "http://626e101c.ngrok.io";          public async Task<IEnumerable<Song>> GetSongsAsync()         {             var res = await GetRequestAsync("/api/songs");             var songObjects = JsonConvert.DeserializeObject<IEnumerable<SongObject>>(res);             return songObjects.Select(x => Convert(x));         }
         public async Task<IEnumerable<Item>> GetItemsAsync()         {             var res = await GetRequestAsync("/api/queues");             var itemObjects = JsonConvert.DeserializeObject<IEnumerable<ItemObject>>(res);             return itemObjects.Select(x => Convert(x));         }          public async Task<Song> GetPlayingAsync()         {             var res = await GetRequestAsync("/playing");             var songObject = JsonConvert.DeserializeObject<SongObject>(res);             return Convert(songObject);         }          public async Task<string> PostItemAsync(int songId, string userName)         {             return await PostRequestAsync("/api/queues", "{\"id\":" + songId + ",\"username\":\"" + userName + "\"}");         } 
        private async Task<string> GetRequestAsync(string endPoint)         {             using (var client = new HttpClient())             {                 var response = await client.GetAsync(URL + endPoint);                 string result = await response.Content.ReadAsStringAsync();                 return result;             }         }          private async Task<string> PostRequestAsync(string endPoint, string json)         {             using (var client = new HttpClient())             {                 var content = new StringContent(json, Encoding.UTF8, "application/json");                 var response = await client.PostAsync(URL + endPoint, content);                 string result = await response.Content.ReadAsStringAsync();                 return result;             }         }          private Song Convert(SongObject songObject)         {             return new Song()
            {
                Id = songObject.Id,
                ArtistName = songObject.ArtistName,
                SongName = songObject.SongName,
                ArtWork = songObject.ArtworkUrl
            };         }          private Item Convert(ItemObject itemObject)         {             return new Item()             {
                Id = itemObject.Id,                 UserName = itemObject.UserName,                 SongName = itemObject.SongObject.SongName,                 ArtistName = itemObject.SongObject.ArtistName,
                ArtWork = itemObject.SongObject.ArtworkUrl,                 Url = itemObject.SongObject.MusicUrl
            };         }     }
}
