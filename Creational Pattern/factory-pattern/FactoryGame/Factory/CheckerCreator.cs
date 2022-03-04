using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGame
{
    internal class CheckerCreator: GameCreator
    {
        public override GameProduct createGame()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Create Checkers game");
            Console.WriteLine("Opponents:2 or 3 or 4 or 6");
            Console.WriteLine("For each opponent, place 10 coins");
            Console.WriteLine("Start Checkers game");
            Console.WriteLine("---------------------------------------");
            return new CheckerProduct();
        }
    }
}
