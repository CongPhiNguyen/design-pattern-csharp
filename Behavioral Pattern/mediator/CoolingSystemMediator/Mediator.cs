using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolingSystemMediator
{
    public class Mediator
    {
        private Button button;
        private Fan fan;
        private PowerSupplier powerSupplier;

        // constructor, getters and setters
        public Mediator(Button button, Fan fan, PowerSupplier powerSupplier)
        {
            this.button = button;
            this.fan = fan;
            this.powerSupplier = powerSupplier;
        }

        public Mediator()
        {
            this.fan = null;
            this.powerSupplier = null;
            this.button = null;
        }
        
        public void press()
        {
            if (fan.isOn)
            {
                fan.turnOff();
            }
            else
            {
                fan.turnOn();
            }
        }

        public void start()
        {
            if(powerSupplier != null)
                powerSupplier.turnOn();
        }

        public void stop()
        {
            if (powerSupplier != null)
                powerSupplier.turnOff();
        }
    }
}
