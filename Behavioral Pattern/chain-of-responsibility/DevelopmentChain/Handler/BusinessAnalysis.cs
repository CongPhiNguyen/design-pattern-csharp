using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChain
{
    public class BusinessAnalysis : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.type == "Indentify Business")
            {
                Console.WriteLine("{0} has indentified business", this.GetType().Name);
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
