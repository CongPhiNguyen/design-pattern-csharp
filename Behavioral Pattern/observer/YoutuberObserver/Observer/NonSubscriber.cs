using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberObserver
{
    internal class NonSubscriber : YoutubeObserver
    {
        private string name = string.Empty;
        public NonSubscriber(string name)
        {
            this.name = name;
        }
        public override void Update(string type)
        {
            Console.WriteLine("{0} Notification: Nothing", this.name);
        }
    }
}
