using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace filesRead
{
    // Abstract class for INI and XML readers
    public abstract class reader
    {
        public List<string> list = new List<string>();
        public abstract void ReadFile(string filepath);
    }

    class Context
    {
        private reader _strategy;

        // Constructor
        public Context(reader strategy)
        {
            _strategy = strategy;
        }

        public reader ReadContext(string filepath)
        {
            _strategy.ReadFile(filepath);
            return _strategy;
        }
    }
}