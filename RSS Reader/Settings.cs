using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace RSS_Reader
{
    public class Settings
    {
        public int refreshDelay;
        public string[] sourceLinks;
        public Settings()
        {
            GetSettings();
        }
        public void GetSettings()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.Combine(Environment.CurrentDirectory, "Settings.xml"));
            sourceLinks = new string[xmlDoc.GetElementsByTagName("link").Count];
            for (int i = 0; i < xmlDoc.GetElementsByTagName("link").Count; i++)
            {
                sourceLinks[i] = xmlDoc.GetElementsByTagName("link")[i].InnerText;
            }
            refreshDelay = Convert.ToInt32(xmlDoc.GetElementsByTagName("Timer")[0].InnerText);
        }
    }
}
