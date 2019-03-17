using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static RSS_Reader.Form1;

namespace RSS_Reader
{
    public static class ListViewItemExtension
    {
        public static void Display(this ListViewItem item, Form1 caller)
        {
            var paper = caller.headlines.GetItem(item.Name);
            caller.descriptionBox.Text = paper.Description;
            caller.linkTitle.Text = paper.Title;
            caller.dateBox.Text = paper.pubDate;
        }
        public static void Link(this ListViewItem item, Form1 caller)
        {
            Process.Start(caller.headlines.GetItem(item.Name).Link);
        }
    }
}
