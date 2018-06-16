using System;
using System.Linq;

namespace ProjectIDEAModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IdeaRemote ideaRemote = new IdeaRemote();
            Console.WriteLine(ideaRemote.PostItemAsync(1, "shirasu").Result);

            foreach(var song in ideaRemote.GetSongsAsync().Result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", song.Id, song.ArtistName, song.ArtWork, song.SongName, song.Url);
            }

            foreach (var item in ideaRemote.GetItemsAsync().Result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.ArtistName, item.ArtWork, item.SongName, item.Url, item.UserName);
            }

            var playing = ideaRemote.GetPlayingAsync().Result;
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", playing.Id, playing.ArtistName, playing.ArtWork, playing.SongName, playing.Url, playing.UserName);
        }
    }
}
