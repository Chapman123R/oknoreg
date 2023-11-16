using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace authorization
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            init();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox()) { resultLabel.Text = "Одна Ошибка И Ты Ошибся"; return; }
            AddUser();
            resultLabel.Text = "Успешно";

        }

        XmlDocument xDoc = new XmlDocument();

        XmlElement xRoot;

        private void init()
        {
            try
            {
                xDoc.Load("logs.txt");
                xRoot = xDoc.DocumentElement;
            }
            catch
            {
                File.WriteAllText("logs.txt", "<users></users>");
                xDoc.Load("logs.txt");
                xRoot = xDoc.DocumentElement;

            }
        }
        private bool CheckTextBox()
        {
            if (textBoxLogReg.Text == "" || textBoxPassReg.Text == "" || textBoxLogReg.Text == null || textBoxPassReg == null) return false;
            return true;
        }

        private void AddUser()
        {
            XmlElement userElem = xDoc.CreateElement("user");
            XmlAttribute userAttr = xDoc.CreateAttribute("login");
            XmlText userTxt = xDoc.CreateTextNode(textBoxLogReg.Text);

            XmlAttribute passAttr = xDoc.CreateAttribute("password");
            XmlText passText = xDoc.CreateTextNode(textBoxPassReg.Text);

            userAttr.AppendChild(userTxt);
            passAttr.AppendChild(passText);

            userElem.Attributes.Append(userAttr);
            userElem.Attributes.Append(passAttr);

            xRoot.AppendChild(userElem);
            xDoc.Save("logs.txt");

        }

        private void buttonReg_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }

}
