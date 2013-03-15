using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using fileClass;

namespace Xml
{

    public sealed class XML : file
    {

        public XML(string filepath)
        {
            ReadFile(filepath);
        }

        public static bool CheckFile(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);

            foreach (string lineCheck in lines)
            {

                if (lineCheck.IndexOf("Target") != -1)
                    return true;
            }
            return false;
        }

        public void ReadFile(string filepath)
        {
            if (CheckFile(filepath))
            {
                string pos;
                int targetCount = 0;

                string[] lines = File.ReadAllLines(filepath);

                    foreach (string line in lines)
                    {
                        
                        if (line.IndexOf("<Target ") != -1)
                        {
                            targetCount++;
                            list.Add("Target " + targetCount);

                            int index1 = line.IndexOf("x") + 6;
                            pos = line.Substring(index1);
                            int index2 = pos.IndexOf(" ") - 1;
                            pos = line.Substring(index1, index2);
                            list.Add("x = "+ pos);

                            index1 = line.IndexOf("y") + 6;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf(" ") - 1;
                            pos = line.Substring(index1, index2);
                            list.Add("y = "+ pos);

                            index1 = line.IndexOf("z") + 6;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf(" ") - 1;
                            pos = line.Substring(index1, index2);
                            list.Add("z = "+ pos);

                            index1 = line.IndexOf("is") + 10;
                            pos = line.Substring(index1);
                            index2 = pos.IndexOf("/") - 2;
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