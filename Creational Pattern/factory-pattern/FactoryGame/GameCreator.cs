using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGame
{
    abstract class GameCreator
    {
        public abstract GameProduct createGame();

    }
}
