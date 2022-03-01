using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGame
{
    internal class LudoCreator: GameCreator
    {
        public override GameProduct createGame()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Create Ludo game");
            Console.WriteLine("Opponents:2 or 3 or 4");
            Console.WriteLine("For each opponent, place 4 coins");
            Console.WriteLine("Create two dices with numbers from 1-6");
            Console.WriteLine("Start Ludo game");
            Console.WriteLine("---------------------------------------");
            return new LudoProduct();
        }
    }
}
