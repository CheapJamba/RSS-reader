using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace RSS_Reader
{
    public partial class Form1 : Form
    {
        public RssItems headlines = new RssItems();
        public Settings settings = new Settings();
        public Settings GetSettings()
        {            
            return settings;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = settings.refreshDelay * 1000;
            RefreshList();
        }

        private void lvNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lvNews.SelectedItems.Count > 0) && (headlines != null) && (headlines.Count > 0))
            {
                lvNews.SelectedItems[0].Display(this);
            }
        }

        private void linkTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvNews.SelectedItems.Count > 0)
            {
                lvNews.SelectedItems[0].Link(this);
            }     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        
        public void RefreshList ()
        {
            headlines.Clear();
            headlines.Fill(settings.sourceLinks);
            lvNews.Clear();
            foreach (RssItem feedItem in headlines)
            {
                ListViewItem listViewItem = new ListViewItem(feedItem.Title);
                if (feedItem.Title.Length > 40)
                {
                    listViewItem.Text = feedItem.Title.Substring(0, 40) + "... (" + feedItem.pubDate + ")";
                }
                else
                {
                    listViewItem.Text = feedItem.Title + "... (" + feedItem.pubDate + ")";
                }
                listViewItem.Name = feedItem.Title;
                lvNews.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
