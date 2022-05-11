using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionInterpreter
{
    public class Context
    {
        private string versionString = "";
        private bool isProgram = false;

        public Context(string versionString)
        {
            this.versionString = versionString; 
        }

        public string getVersionString()
        {
            return this.versionString;
        }

        public int getLength()
        {
            return this.versionString.Length;
        }

        public string getProgramName()
        {
            int count = 0;
            for(int i = 0; i < versionString.Length; i++)
            {
                if (versionString[i] == '-') count++;
            }
            if (count != 2)
            {
                return "";
            }
            else
                return versionString.Substring(0, versionString.IndexOf('-'));
        }

        public string getVersion()
        {
            int count = 0;
            for (int i = 0; i < versionString.Length; i++)
            {
                if (versionString[i] == '-') count++;
            }
            if (count != 2)
            {
                return "";
            }
            int firstIndex = versionString.IndexOf('-');
            int secondIndex = versionString.IndexOf('-', firstIndex + 1);

            return versionString.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
        }

        public string getOS()
        {
            int count = 0;
            for (int i = 0; i < versionString.Length; i++)
            {
                if (versionString[i] == '-') count++;
            }
            if (count != 2)
            {
                return "";
            }
            int firstIndex = versionString.IndexOf('-');
            int secondIndex = versionString.IndexOf('-', firstIndex + 1);

            return versionString.Substring(secondIndex + 1, versionString.Length - secondIndex - 1);
        }

        public void setIsProgram( bool isProgram)
        {
            this.isProgram = isProgram;
        }

        public bool getIsProgram()
        {
            return isProgram;
        }
    }
}
