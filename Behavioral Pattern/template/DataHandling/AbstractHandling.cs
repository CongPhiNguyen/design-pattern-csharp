using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling
{
    public abstract class AbstractHandling
    {
        public void templateMethod() {
            this.connectDatabase();
            this.pdfConvert();
            this.handlingData();
            this.downloadPicture();
            this.processPicture();
            this.closingConnection();
        }

        //Require method
        public abstract void connectDatabase();
        public abstract void closingConnection();

        //Hook method
        public virtual void downloadPicture() { }
        public virtual void processPicture() { }
        public virtual void pdfConvert() { }
        public virtual void handlingData() { }

    }
}
