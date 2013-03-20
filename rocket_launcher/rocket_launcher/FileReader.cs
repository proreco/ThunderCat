using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using fileClass;
using Ini;
using Xml;

// File reader singleton factory
namespace fileReader
{
    public enum FileType
    {
        xml,
        ini
    }
    public class FileReader
    {
        private static FileReader instance;

        private FileReader()
        {
        }

        public static FileReader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileReader();
                }
                return instance;
            }
        }
        public file addFile(string filefetch)
        {
            FileType fType = 0;
            string path="/0";
           
                
                string extension = Path.GetExtension(filefetch);

                if (extension == ".ini" || extension == ".INI")
                    fType = FileType.ini;
                else if (extension == ".xml" || extension == ".XML")
                    fType = FileType.xml;
                else
                    Console.WriteLine("Invalid file");

                if (fType == FileType.ini || fType == FileType.xml)
                {
                    path = filefetch;
                }
            
            file file = null;
            switch (fType)
            {  
                case FileType.ini:
                    file = new INI(path);
                    break;
                case FileType.xml:
                    file = new XML(path);
                    break;
                default:
                    break;
            }
            return file;
        }
    }  
}
