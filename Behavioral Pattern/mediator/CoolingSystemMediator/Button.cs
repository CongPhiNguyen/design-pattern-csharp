using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolingSystemMediator
{
    public class Button
    {
        private Mediator mediator = new Mediator();
        public void press()
        {
            mediator.press();
        }
    }
}
