using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberObserver
{
    public class Subscriber : YoutubeObserver
    {
        private string name = string.Empty;
        private Youtuber youtuber;
        public Subscriber(Youtuber youtubeSubject, string name)
        {
            this.youtuber = youtubeSubject;
            this.name = name;
        }
        public override void Update(string type)
        {
            Console.WriteLine("{0} Notification: {1} {2}", this.name, this.youtuber.Name, type);
        }
    }
}
