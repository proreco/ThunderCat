using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using filesRead;

namespace Xml
{
    // XML file reader
    public sealed class XMLreader : reader
    {
        // Check if file has a right format
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
        // ReadFile function calls Check functions 
        // and then reads file and writes it to the target list
        public override void ReadFile(string filepath)
        {
            if (CheckFile(filepath))
            {
                XmlReaderSettings readerSettings = new XmlReaderSettings();
                readerSettings.IgnoreComments = true;
                using (XmlReader reader = XmlReader.Create(filepath, readerSettings))
                {
                    // The load the document DOM
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);

                    // Grab the first node
                    XmlNode mainNode = document.FirstChild;
                    mainNode = mainNode.NextSibling;

                    XmlElement element = document.GetElementById("Targets");

                    // Then get the list of nodes containing the data we want. 
                    XmlNodeList nodes = mainNode.ChildNodes; //.ChildNodes;
                    int targetCount = 0;
                    foreach (XmlNode node in nodes)
                    {
                        targetCount++;
                        bool isFriend = Convert.ToBoolean(node.Attributes["isFriend"].Value);
                        double yPos = Convert.ToDouble(node.Attributes["yPos"].Value);
                        double xPos = Convert.ToDouble(node.Attributes["xPos"].Value);
                        double zPos = Convert.ToDouble(node.Attributes["zPos"].Value);
                        string Name = Convert.ToString(node.Attributes["Name"].Value);

                        XmlAttribute attribute = node.Attributes[0];
                        list.Add("Target " + targetCount);
                        list.Add("x = " + xPos);
                        list.Add("y = " + yPos);
                        list.Add("z = " + zPos);
                        list.Add("Friend = " + isFriend);
                        list.Add("Name = " + Name);
                        list.Add("\n");
                    }
                }
            }
        }   
    }
}