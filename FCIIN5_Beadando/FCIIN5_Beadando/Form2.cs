using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIIN5_Beadando
{
    public partial class Form2 : Form
    {
        public class Trackbarosztaly : TrackBar {
            public Trackbarosztaly() {
                this.Height = 90;
                this.Width = 900;
                this.Minimum = 0;
                this.Maximum = 100;
                this.TickFrequency = 5;
                this.TickStyle = TickStyle.BottomRight;
                this.Left = 35;
                this.Top = 100;
            }
        }
        public class labelosztaly : Label {
            public labelosztaly() {
                this.Height = 200;
                this.Width= 200;
                this.Left = 450;
                this.Top = 50;
                this.Font = new Font("Times New Roman", 30.0f);
            }
        }
        Trackbarosztaly tc1 = new Trackbarosztaly();
        labelosztaly label1 = new labelosztaly();

        public Form2() {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) {
            this.Controls.Add(tc1);
            this.Controls.Add(label1);
            tc1.Scroll += Tc1_Scroll;
        }

        private void Tc1_Scroll(object sender, EventArgs e) {
            label1.Text = tc1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Ön programunkkal az alábbi mértékben volt elégedett: " + tc1.Value.ToString()+ "\t\tKöszönjük válaszát!");
        }
    }
}
