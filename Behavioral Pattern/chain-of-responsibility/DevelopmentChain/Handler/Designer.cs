using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChain
{
    public class Designer : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.type == "Design database" || request.type ==  "Design UI/UX")
            {
                Console.WriteLine("{0} has {1}", this.GetType().Name, request.type);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("{0} can't be handled", request.type);
            }
        }
    }
}
