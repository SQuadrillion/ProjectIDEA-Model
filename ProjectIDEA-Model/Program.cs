using System;
using System.Linq;

namespace ProjectIDEAModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IdeaRemote ideaRemote = new IdeaRemote();

            foreach (var item in ideaRemote.GetItemsAsync().Result)
            {
                Console.WriteLine("{0} {1}", item.Id, item.ArtistName);
            }
        }
    }
}
