namespace FCIIN5_Beadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kereses = new System.Windows.Forms.Button();
            this.keresesinput = new System.Windows.Forms.TextBox();
            this.keresesieredmeny = new System.Windows.Forms.ListView();
            this.termekpaletta = new System.Windows.Forms.Button();
            this.termeklista = new System.Windows.Forms.ListView();
            this.ListaGomb = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.TorlesGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kereses
            // 
            this.Kereses.Location = new System.Drawing.Point(338, 9);
            this.Kereses.Name = "Kereses";
            this.Kereses.Size = new System.Drawing.Size(110, 23);
            this.Kereses.TabIndex = 0;
            this.Kereses.Text = "Keresés";
            this.Kereses.UseVisualStyleBackColor = true;
            this.Kereses.Click += new System.EventHandler(this.Kereses_Click);
            // 
            // keresesinput
            // 
            this.keresesinput.Location = new System.Drawing.Point(12, 12);
            this.keresesinput.Name = "keresesinput";
            this.keresesinput.Size = new System.Drawing.Size(305, 20);
            this.keresesinput.TabIndex = 1;
            // 
            // keresesieredmeny
            // 
            this.keresesieredmeny.HideSelection = false;
            this.keresesieredmeny.Location = new System.Drawing.Point(12, 38);
            this.keresesieredmeny.Name = "keresesieredmeny";
            this.keresesieredmeny.Size = new System.Drawing.Size(305, 400);
            this.keresesieredmeny.TabIndex = 2;
            this.keresesieredmeny.UseCompatibleStateImageBehavior = false;
            this.keresesieredmeny.View = System.Windows.Forms.View.List;
            // 
            // termekpaletta
            // 
            this.termekpaletta.Location = new System.Drawing.Point(338, 38);
            this.termekpaletta.Name = "termekpaletta";
            this.termekpaletta.Size = new System.Drawing.Size(110, 23);
            this.termekpaletta.TabIndex = 3;
            this.termekpaletta.Text = "Termékpaletta ";
            this.termekpaletta.UseVisualStyleBackColor = true;
            this.termekpaletta.Click += new System.EventHandler(this.termekpaletta_Click);
            // 
            // termeklista
            // 
            this.termeklista.HideSelection = false;
            this.termeklista.Location = new System.Drawing.Point(338, 67);
            this.termeklista.Name = "termeklista";
            this.termeklista.Size = new System.Drawing.Size(110, 371);
            this.termeklista.TabIndex = 4;
            this.termeklista.UseCompatibleStateImageBehavior = false;
            this.termeklista.View = System.Windows.Forms.View.List;
            // 
            // ListaGomb
            // 
            this.ListaGomb.Location = new System.Drawing.Point(486, 38);
            this.ListaGomb.Name = "ListaGomb";
            this.ListaGomb.Size = new System.Drawing.Size(75, 23);
            this.ListaGomb.TabIndex = 5;
            this.ListaGomb.Text = "Listáz";
            this.ListaGomb.UseVisualStyleBackColor = true;
            this.ListaGomb.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.Location = new System.Drawing.Point(486, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 225);
            this.listView1.TabIndex = 6;
            // 
            // TorlesGomb
            // 
            this.TorlesGomb.Location = new System.Drawing.Point(731, 38);
            this.TorlesGomb.Name = "TorlesGomb";
            this.TorlesGomb.Size = new System.Drawing.Size(75, 23);
            this.TorlesGomb.TabIndex = 7;
            this.TorlesGomb.Text = "Törlés";
            this.TorlesGomb.UseVisualStyleBackColor = true;
            this.TorlesGomb.Click += new System.EventHandler(this.TorlesGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 465);
            this.Controls.Add(this.TorlesGomb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ListaGomb);
            this.Controls.Add(this.termeklista);
            this.Controls.Add(this.termekpaletta);
            this.Controls.Add(this.keresesieredmeny);
            this.Controls.Add(this.keresesinput);
            this.Controls.Add(this.Kereses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kereses;
        private System.Windows.Forms.TextBox keresesinput;
        private System.Windows.Forms.ListView keresesieredmeny;
        private System.Windows.Forms.Button termekpaletta;
        private System.Windows.Forms.ListView termeklista;
        private System.Windows.Forms.Button ListaGomb;
        private System.Windows.Forms.ListBox listView1;
        private System.Windows.Forms.Button TorlesGomb;
    }
}

