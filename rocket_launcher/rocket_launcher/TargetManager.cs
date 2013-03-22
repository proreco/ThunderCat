using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using filesRead;

namespace targetManager
{
    class TargetManager
    {
        /// <summary>
        /// This is the signature that the 
        /// </summary>
        /// <param name="animal"></param>
        public delegate void AddTarget(object sender,  file target);

        public event AddTarget AddedTarget;

        public void addTarget(file target)
        {
            if (AddedTarget != null)
            {
                AddedTarget(this, target);
            }
        }

    }
}
