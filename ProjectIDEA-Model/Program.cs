using System;
using System.Linq;

namespace ProjectIDEAModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IdeaRemote ideaRemote = new IdeaRemote();
            Console.WriteLine(ideaRemote.PostItemAsync(1, "shirauu").Result);
        }
    }
}
