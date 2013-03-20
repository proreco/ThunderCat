using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fileClass
{
    // Abstract class for INI and XML readers
    public abstract class file
    {
        public List<string> list = new List<string>();
        public abstract bool CheckFile(string filepath);
        public abstract void ReadFile(string filepath);
    }
}
