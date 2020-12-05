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
            }
            else
            {
                MessageBox.Show("Nem megfelelő beviteli paraméterek");
                keresesinput.Text = string.Empty;
                keresesinput.Focus();
            }
        }
    }
}
