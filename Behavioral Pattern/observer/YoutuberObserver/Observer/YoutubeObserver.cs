using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberObserver
{
    public abstract class YoutubeObserver
    {
        public abstract void Update(string type);
    }
}
