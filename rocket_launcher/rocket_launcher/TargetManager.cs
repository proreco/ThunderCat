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
        // Target manager class, manages list of targets and encapsulates targets' data.
        private int x, y, z;
        private bool friend;
        private string name;
        public List<string> targetList = new List<string>();
        private List<string> targetRemove = new List<string>();

        public delegate void AddTarget(object sender,  reader target);

        public event AddTarget AddedTarget;

        public void addTarget(reader target)
        {
            if (AddedTarget != null)
            {
                targetList.Clear();
                targetList.AddRange(target.list);
                AddedTarget(this, target);
            }
        }
        public void SetTarget(int target_number)
        {
            int lines = 7;
            int targetEnd = 1;
            bool correct_target = false;
            foreach (string line in targetList)
            {
                if (line.StartsWith("Target " + target_number))
                    correct_target = true;
                if (targetEnd == 7)
                    correct_target = false;

                if (correct_target) 
                {
                    if (line.StartsWith("x"))
                        x = Convert.ToInt32(line.Remove(0, 4));
                    else if (line.StartsWith("y"))
                        y = Convert.ToInt32(line.Remove(0, 4));
                    else if (line.StartsWith("z"))
                        z = Convert.ToInt32(line.Remove(0, 4));
                    else if (line == "Friend = True")
                        friend = true;
                    else if (line == "Friend = False")
                        friend = false;
                    else if (line.StartsWith("Name = "))
                        name = line.Remove(0, 7);
                    targetEnd++;
                    targetRemove.Add(line);
                    
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
