using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using fileClass;

namespace Ini
{
    // INI file reader
    public class INI : file
    {
        public INI(string filepath)
        {
            ReadFile(filepath);
        }

        public override bool CheckFile(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            foreach (string lineCheck in lines)
            {
                if (lineCheck.StartsWith("T"))
                {
                    return false;
                }
                else if (lineCheck.StartsWith("[") && !lineCheck.EndsWith("]"))
                {
                    return false;
                }
                else if (!lineCheck.StartsWith("[") && lineCheck.EndsWith("]"))
                {
                    return false;
                }
            }
            return true;
        }

        public override void ReadFile(string filepath)
        {

            if (CheckFile(filepath))
            {
                bool target = false;
                int targetCount = 0;

                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("[") && line.EndsWith("]") && target == false)
                    {
                        targetCount++;
                        list.Add("Target " + targetCount);
                    }
                    else if (line.StartsWith(";"))
                    {
                    }
                    else if (line.StartsWith("x") || line.StartsWith("y") || line.StartsWith("z"))
                    {
                        list.Add(line);
                    }
                    else
                        list.Add(line);
                }
            }
        }       
      }
    }