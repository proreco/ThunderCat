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
        private int x, y, z;
        private bool friend;
        private string name;
        private List<string> targetList = new List<string>();

        /// <summary>
        /// This is the signature that the 
        /// </summary>
        /// <param name="animal"></param>
        public delegate void AddTarget(object sender,  reader target);

        public event AddTarget AddedTarget;

        public void addTarget(reader target)
        {
            if (AddedTarget != null)
            {
                targetList.AddRange(target.list);
                AddedTarget(this, target);
            }
        }

        public void SetTarget(int target_number)
        {
            int lines = 7;
            int targetEnd = 1;
            foreach (string line in targetList)
            {
                
                if ((target_number)*7 <= lines && targetEnd != 7)
                {
                    if (line.StartsWith("x"))
                        x = Convert.ToInt32(line.Remove(0, 4));
                    else if (line.StartsWith("y"))
                        y = Convert.ToInt32(line.Remove(0, 4));
                    else if (line.StartsWith("z"))
                        z = Convert.ToInt32(line.Remove(0, 4));
                    else if (line == "friend = yes")
                        friend = true;
                    else if (line == "friend = no")
                        friend = false;
                    else if (line.StartsWith("name  "))
                        name = line.Remove(0, 7);
                    targetEnd++;
                }
                lines++;
            }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public bool Friend
        {
            get { return friend; }
            set { friend = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<string> TargetList
        {
            get { return targetList; }
        }
    }
}
