using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using filesRead;
using WinForm;

namespace Ini
{
    // INI file reader
    public class INIreader : reader
    {
        public INIreader(string filepath)
        {
            ReadFile(filepath);
        }
        // Check if file has a right format
        private bool CheckFile(string filepath)
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
        // ReadFile function calls Check functions 
        // and then reads file and writes it to the target list
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
                    else if (line.StartsWith("x") || line.StartsWith("y") || line.StartsWith("z") && !line.EndsWith("."))
                        list.Add(line);
                    else if (line.StartsWith("x") || line.StartsWith("y") || line.StartsWith("z") && line.EndsWith("."))
                        list.Add(line.TrimEnd('.'));
                    else if (line == "friend = yes")
                        list.Add("Friend = True");
                    else if (line == "friend = no")
                        list.Add("Friend = False");
                    else if (line.StartsWith("name  "))
                    {
                        list.Add("Name" + line.Remove(0, 6));
                        list.Add("\n");
                    }
                }
            }
        }       
    }
}