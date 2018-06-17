using System;
using System.Linq;

namespace ProjectIDEAModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IdeaRemote ideaRemote = new IdeaRemote();
            //Console.WriteLine(ideaRemote.PostItemAsync(3, "musa").Result);

            //foreach(var song in ideaRemote.GetSongsAsync().Result)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4}", song.Id, song.ArtistName, song.ArtWork, song.SongName, song.Url);
            //}



            foreach (var item in ideaRemote.GetItemsAsync().Result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.ArtistName, item.ArtWork, item.SongName, item.Url, item.UserName);
            }

            //var playing = ideaRemote.GetPlayingAsync().Result;
            //Console.WriteLine("{0} {1} {2} {3} {4} {5}", playing.Id, playing.ArtistName, playing.ArtWork, playing.SongName, playing.Url, playing.UserName);

            //var song = ideaRemote.PostSongAsync("http://show-en-kei.com/kyoboku/kb_tohoku/kb_yamagata/kb_yamagata_img/kb_yamagata_m_tozawa_02/view_07.jpg",
            //                                    "http://amachamusic.chagasi.com/mp3/kasumisou.mp3").Result;
            //Console.WriteLine("{0} {1} {2} {3} {4}", song.Id, song.ArtistName, song.ArtWork, song.SongName, song.Url);
        }
    }
}
