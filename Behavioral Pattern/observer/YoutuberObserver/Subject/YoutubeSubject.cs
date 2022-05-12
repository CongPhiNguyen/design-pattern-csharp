using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberObserver
{
    public abstract class YoutubeSubject
    {
        protected List<YoutubeObserver> youtubeObservers = new List<YoutubeObserver>();
        public void Attach(YoutubeObserver youtubeObserver)
        {
            youtubeObservers.Add(youtubeObserver);
        }
        public void Dettach(YoutubeObserver youtubeObserver)
        {
            youtubeObservers.Remove(youtubeObserver);
        }
        
    }
}
