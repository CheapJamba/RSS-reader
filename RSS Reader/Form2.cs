using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace RSS_Reader
{
    public partial class Form2 : Form
    {       
        XmlDocument settingsDocument = new XmlDocument();
        Form1 mainForm;
        public Form2(Form1 Form)
        {
            settingsDocument.Load(Path.Combine(Environment.CurrentDirectory, "Settings.xml"));
            mainForm = Form;
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string source in mainForm.settings.sourceLinks)
            {
                SourcesListBox.Items.Add(source);
            }
            RefreshDelayTextBox.Text = mainForm.settings.refreshDelay.ToString();
        }

        private void NewSourceButton_Click(object sender, EventArgs e)
        {
            if (NewSourceTextBox.Text.Length != 0)
            {
                if (IsRss(NewSourceTextBox.Text))
                {
                    SourcesListBox.Items.Add(NewSourceTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("Заполните текстовое поле");
            }
        }

        private void SaveSourceList ()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path.Combine(Environment.CurrentDirectory, "Settings.xml"));
            xmlDoc.GetElementsByTagName("Links")[0].RemoveAll();
            foreach (string link in SourcesListBox.Items)
            {
                XmlNode docLinks = xmlDoc.GetElementsByTagName("Links")[0];
                XmlElement docLink = xmlDoc.CreateElement("link");
                XmlText docLinkText = xmlDoc.CreateTextNode(link);
                docLink.AppendChild(docLinkText);
                docLinks.AppendChild(docLink);
            }
            if (RefreshDelayTextBox.Text.Length != 0)
            xmlDoc.GetElementsByTagName("Timer")[0].InnerText = RefreshDelayTextBox.Text;
            xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "Settings.xml"));
            mainForm.settings.GetSettings();
            mainForm.RefreshList();
        }

        public bool IsRss(string Url)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(Url);
            }
            catch (System.Xml.XmlException)
            {
                MessageBox.Show("Данный источник не содержит файл формата Rss");
                return false;
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                {
                    MessageBox.Show("Невозможно соединиться с указанным источником.\r\n" + Url);
                    return false;
                }
                else throw ex;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл " + Url + " не найден!");
                return false;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Путь содержит недопустимые знаки");
                return false;
            }
            catch (System.NotSupportedException)
            {
                MessageBox.Show("Данный источник не содержит файл формата Rss");
                return false;
            }
            if (xmlDoc.GetElementsByTagName("channel").Count != 0)
            {
                return true;
            }
            return false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            SaveSourceList();
            this.Close();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteSourceButton_Click(object sender, EventArgs e)
        {
            SourcesListBox.Items.Remove(SourcesListBox.SelectedItem);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void RefreshDelayTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!(RefreshDelayTextBox.Text.Length > 0 && Convert.ToInt32(RefreshDelayTextBox.Text) > 600))
                {
                    MessageBox.Show("Введите значение >= 600");
                    RefreshDelayTextBox.Text = "3600";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("В данное поле вводите только числа");
                RefreshDelayTextBox.Text = "3600";
            }

        }
    }
}
