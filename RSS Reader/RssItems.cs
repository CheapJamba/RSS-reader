using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSS_Reader
{
    public class RssItems : List<RssItem>
    {
        
        new public bool Contains (RssItem item)
        {
            foreach (RssItem itemForCheck in this)
            {
                if (item.Title == itemForCheck.Title)
                {
                    return true;
                }     
            }
            return false;
        }

        public RssItem GetItem(string title)
        {
            foreach (RssItem itemForCheck in this)
            {
                if (itemForCheck.Title == title)
                {
                    return itemForCheck;
                }
            }
            return null;
        }

        public void Fill(string[] sources)
        {
            var xmlDoc = new XmlDocument();
            foreach (string source in sources)
            {
                try
                {
                    xmlDoc.Load(source);
                    XmlNode channelXmlNode = xmlDoc.GetElementsByTagName("channel")[0];
                    if (channelXmlNode != null)
                    {
                        foreach (XmlNode channelNode in channelXmlNode.ChildNodes)
                        {
                            if (channelNode.Name == "item")
                            {
                                RssItem channelItem = new RssItem(channelNode);
                                if (!Contains(channelItem))
                                {
                                    Add(channelItem);
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Ошибка в XML. Описание не найдено!");
                    }
                }
                catch (System.Net.WebException ex)
                {
                    if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                        throw new Exception("Невозможно соединиться с указанным источником.\r\n" + source);
                    else throw ex;
                }
                catch (System.IO.FileNotFoundException)
                {
                    throw new Exception("Файл " + source + "не найден!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                Sort((a, b) => b.pubDateDT.CompareTo(a.pubDateDT));
            }
            
        }
    }    
}
