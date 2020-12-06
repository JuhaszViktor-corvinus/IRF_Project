﻿using System;
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

namespace FCIIN5_Beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void Kereses_Click(object sender, EventArgs e)
        {
            if (keresesinput.Text != null && keresesinput.Text.Length >= 3)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Termekek.xml");

                foreach(XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == keresesinput.Text)
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            keresesieredmeny.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem megfelelő beviteli paraméterek");
                keresesinput.Text = string.Empty;
                keresesinput.Focus();
            }
        }    

        private void termekpaletta_Click(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create("Termekek.xml");
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "termekek"))
                {
                    if (reader.HasAttributes)
                    {
                        termeklista.Items.Add(reader.GetAttribute("name"));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
