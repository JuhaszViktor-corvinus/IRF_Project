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
            this.keresesieredmeny.Size = new System.Drawing.Size(436, 400);
            this.keresesieredmeny.TabIndex = 2;
            this.keresesieredmeny.UseCompatibleStateImageBehavior = false;
            this.keresesieredmeny.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

