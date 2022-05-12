using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberObserver
{
    public class Youtuber : YoutubeSubject
    {
        public string name = string.Empty;
        public string Name { get { return name; } }
        public Youtuber(string name)
        {
            this.name = name;
        }
        public void PostANormalVideo()
        {
            foreach (YoutubeObserver youtubeObserver in youtubeObservers)
            {
                if (youtubeObserver.GetType().Name == "Membership" || youtubeObserver.GetType().Name == "Subscriber")
                {
                    youtubeObserver.Update("Post a new video");
                }
            }
        }

        public void PostMembershipVideo()
        {
            foreach (YoutubeObserver youtubeObserver in youtubeObservers)
            {
                if (youtubeObserver.GetType().Name == "Membership")
                {
                    youtubeObserver.Update("Post a membership video");
                }
            }
        }
    }
}
