using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        IEnumerable<Termek> Termekek;

        private void Kereses_Click(object sender, EventArgs e)
        {
            try
            {
                if (keresesinput.Text != null && keresesinput.Text.Length >= 3)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Termekek.xml");

                    foreach (XmlNode node in doc.DocumentElement)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.listView1.Items.Clear();

                this.Termekek = from termek in XDocument.Load("Termekek.xml").Root
                                                                  .Descendants("termekek")

                                select new Termek
                                {
                                    Ar = Int32.Parse(termek.Element("ár").Value),
                                    Gyartasido = termek.Element("gyártásido").Value,
                                    Gyarto = termek.Element("gyártó").Value,
                                    Szin = termek.Element("szín").Value,
                                    name = termek.Attribute("name").Value
                                };
                foreach (Termek term in this.Termekek)
                {
                    listView1.Items.Add(term.name + "\t\t" + term.Ar.ToString() + "\t\t" + term.Gyartasido + "\t\t" + term.Gyarto + "\t\t" + term.Szin);
                }
                var attributes = XDocument.Load("Termekek.xml").Root.Attributes();
                var elements = XDocument.Load("Termekek.xml").Root.Elements();
                var attr2 = elements.Attributes();
                var elem2 = elements.Elements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }                
    }
}
