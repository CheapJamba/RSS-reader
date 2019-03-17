using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml;

namespace RSS_Reader
{
    public class RssItem : ListViewItem
    {
        public string Title;
        public string Link;
        public string Description;
        public string pubDate;
        public DateTime pubDateDT;
        Regex tagEx = new Regex(@"<[^>]*>", RegexOptions.Compiled);
        public RssItem (XmlNode itemTag)
        {
            foreach (XmlNode xmlTag in itemTag.ChildNodes)
            {
                switch (xmlTag.Name)
                {
                    case "title":
                        {
                            Title = xmlTag.InnerText;
                            Text = xmlTag.InnerText;
                            break;
                        }
                    case "description":
                        {
                            string descText = xmlTag.InnerText;                            
                            Description = tagEx.Replace(descText, "");
                            break;
                        }
                    case "link":
                        {
                            Link = xmlTag.InnerText;
                            break;
                        }
                    case "pubDate":
                        pubDateDT = DateTime.Parse(xmlTag.InnerText);
                        pubDate = pubDateDT.ToString("dd.MM.yy");                                         
                        break;
                }
            }
        }
    }
}
