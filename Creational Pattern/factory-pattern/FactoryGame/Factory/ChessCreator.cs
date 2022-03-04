using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGame
{
    internal class ChessCreator: GameCreator
    {
        public override GameProduct createGame()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Create Chessgame");
            Console.WriteLine("Opponents:2");
            Console.WriteLine("Define 64 blocks");
            Console.WriteLine("Place 16 pieces for White opponent");
            Console.WriteLine("Place 16 pieces for Black opponent");
            Console.WriteLine("Start Chess game");
            Console.WriteLine("---------------------------------------");
            return new ChessProduct();
        }
    }
}
