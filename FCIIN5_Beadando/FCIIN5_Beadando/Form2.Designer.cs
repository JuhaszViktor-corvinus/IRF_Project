namespace FCIIN5_Beadando
{
    partial class Form2
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
            this.Jovahagyas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jovahagyas
            // 
            this.Jovahagyas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jovahagyas.Location = new System.Drawing.Point(305, 181);
            this.Jovahagyas.Name = "Jovahagyas";
            this.Jovahagyas.Size = new System.Drawing.Size(290, 41);
            this.Jovahagyas.TabIndex = 0;
            this.Jovahagyas.Text = "Értékelés jóváhagyása.";
            this.Jovahagyas.UseVisualStyleBackColor = true;
            this.Jovahagyas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kérjük mondja el véleményét mennyire volt elégedett programunkkal:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(974, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Jovahagyas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jovahagyas;
        private System.Windows.Forms.Label label2;
    }
}