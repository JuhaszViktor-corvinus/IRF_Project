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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimumAr = new System.Windows.Forms.TextBox();
            this.MaximumAr = new System.Windows.Forms.TextBox();
            this.TorlesArSzerintGomb = new System.Windows.Forms.Button();
            this.Mentes = new System.Windows.Forms.Button();
            this.ElegedettsegErt = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maximum";
            // 
            // MinimumAr
            // 
            this.MinimumAr.Location = new System.Drawing.Point(557, 350);
            this.MinimumAr.Name = "MinimumAr";
            this.MinimumAr.Size = new System.Drawing.Size(100, 20);
            this.MinimumAr.TabIndex = 13;
            // 
            // MaximumAr
            // 
            this.MaximumAr.Location = new System.Drawing.Point(557, 392);
            this.MaximumAr.Name = "MaximumAr";
            this.MaximumAr.Size = new System.Drawing.Size(100, 20);
            this.MaximumAr.TabIndex = 14;
            // 
            // TorlesArSzerintGomb
            // 
            this.TorlesArSzerintGomb.Location = new System.Drawing.Point(483, 312);
            this.TorlesArSzerintGomb.Name = "TorlesArSzerintGomb";
            this.TorlesArSzerintGomb.Size = new System.Drawing.Size(174, 23);
            this.TorlesArSzerintGomb.TabIndex = 15;
            this.TorlesArSzerintGomb.Text = "Ár szerinti törlés";
            this.TorlesArSzerintGomb.UseVisualStyleBackColor = true;
            this.TorlesArSzerintGomb.Click += new System.EventHandler(this.TorlesArSzerintGomb_Click);
            // 
            // Mentes
            // 
            this.Mentes.Location = new System.Drawing.Point(716, 350);
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(176, 62);
            this.Mentes.TabIndex = 16;
            this.Mentes.Text = "Mentés";
            this.Mentes.UseVisualStyleBackColor = true;
            this.Mentes.Click += new System.EventHandler(this.Mentes_Click);
            // 
            // ElegedettsegErt
            // 
            this.ElegedettsegErt.Location = new System.Drawing.Point(963, 350);
            this.ElegedettsegErt.Name = "ElegedettsegErt";
            this.ElegedettsegErt.Size = new System.Drawing.Size(176, 62);
            this.ElegedettsegErt.TabIndex = 17;
            this.ElegedettsegErt.Text = "Elégedettség Értékelés";
            this.ElegedettsegErt.UseVisualStyleBackColor = true;
            this.ElegedettsegErt.Click += new System.EventHandler(this.ElegedettsegErt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1200, 465);
            this.Controls.Add(this.ElegedettsegErt);
            this.Controls.Add(this.Mentes);
            this.Controls.Add(this.TorlesArSzerintGomb);
            this.Controls.Add(this.MaximumAr);
            this.Controls.Add(this.MinimumAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinimumAr;
        private System.Windows.Forms.TextBox MaximumAr;
        private System.Windows.Forms.Button TorlesArSzerintGomb;
        private System.Windows.Forms.Button Mentes;
        private System.Windows.Forms.Button ElegedettsegErt;
    }
}

