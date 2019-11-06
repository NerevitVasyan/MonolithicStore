using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicStore.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Server.GamesServiceClient();

            var games = client.GetGames();

            foreach(var game in games)
            {
                Console.WriteLine(game.Name);
            }

        }
    }
}
