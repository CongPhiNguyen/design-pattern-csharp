using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling
{
    public class PictureHandling : AbstractHandling
    {
        public override void connectDatabase()
        {
            Console.WriteLine("Connecting to picture database");
        }
        public override void closingConnection()
        {
            Console.WriteLine("Closing connect of picture database");
        }

        public override void downloadPicture()
        {
            Console.WriteLine("Downloading picture from database");
        }

        public override void processPicture()
        {
            Console.WriteLine("Processing data of the picture");
        }
    }
}
