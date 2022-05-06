using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolingSystemMediator
{
    public class Fan
    {
        private Mediator mediator = new Mediator();
        public bool isOn = false;
        public void turnOn()
        {
            Console.WriteLine("Turn on fan");
            mediator.start();
            isOn = true;
        }

        public void turnOff()
        {
            Console.WriteLine("Turn off fan");
            isOn = false;
            mediator.stop();
        }
    }
}
