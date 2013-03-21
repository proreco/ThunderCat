using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using filesRead;

namespace Xml
{
    // XML file reader
    public sealed class XML : file
    {
        public XML(string filepath)
        {
            ReadFile(filepath);
        }
        private bool CheckFile(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);

            foreach (string lineCheck in lines)
            {
                if (lineCheck.IndexOf("Target") != -1)
                    return true;
            }
            return false;
        }
        public override void ReadFile(string filepath)
        {
            if (CheckFile(filepath))
            {
                string pos;
                int targetCount = 0;
                int char10 = 10,
                    char6 = 6,
                    char2 = 2,
                    char1 = 1;

                string[] lines = File.ReadAllLines(filepath);

                    foreach (string line in lines)
                    {                       
                        if (line.IndexOf("<Target ") != -1)
                        {
                            targetCount++;
                            list.Add("Target " + targetCount);

                            int index1 = line.IndexOf("x") + char6;
                            pos = line.Substring(index1);
                            int index2 = pos.IndexOf(" ") - char1;
                            pos = line.Substring(index1, index2);
                            list.Add("x = "+ pos);
                            
                            index1 = line.IndexOf("y") + char6;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf(" ") - char1;
                            pos = line.Substring(index1, index2);
                            list.Add("y = "+ pos);

                            index1 = line.IndexOf("z") + char6;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf(" ") - char1;
                            pos = line.Substring(index1, index2);
                            list.Add("z = "+ pos);                      

                            index1 = line.IndexOf("is") + char10;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf("/") - char2;
                            pos = line.Substring(index1, index2);

                            if (pos == "True")
                                list.Add("friend = yes");
                            else
                                list.Add("friend = No");
                            list.Add("");
                        }
                    }
            }
        }   
    }
}