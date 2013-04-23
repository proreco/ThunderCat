using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using filesRead;

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

        static public FileReader GetInstance()
        {
            
                if (instance == null)
                {
                    instance = new FileReader();
                }
                return instance;
            
        }
        // Adds file to reader and checks if it is of a right format
        public reader readFile(string filefetch)
        {
            FileType fType = 0;
            string path="/0";
           
                
            string extension = Path.GetExtension(filefetch);

            if (extension == ".ini" || extension == ".INI" || extension == ".Ini")
                fType = FileType.ini;
            else if (extension == ".xml" || extension == ".XML" || extension == ".Xml")
                fType = FileType.xml;

            if (fType == FileType.ini || fType == FileType.xml)
            {
                path = filefetch;
            }
            Context context;
            reader file = null;
            switch (fType)
            {  
                case FileType.ini:
                    context = new Context(new Ini.INIreader());
                    file = context.ReadContext(path);
                    break;
                case FileType.xml:
                    context = new Context(new Xml.XMLreader());
                    file = context.ReadContext(path);
                    break;
                default:
                    break;
            }
            return file;
        }
    }  
}