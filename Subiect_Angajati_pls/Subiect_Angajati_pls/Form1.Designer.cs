namespace Subiect_Angajati_pls
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
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.btnXLM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAngajati
            // 
            this.lvAngajati.FullRowSelect = true;
            this.lvAngajati.GridLines = true;
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(36, 33);
            this.lvAngajati.MultiSelect = false;
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(716, 154);
            this.lvAngajati.TabIndex = 0;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.DoubleClick += new System.EventHandler(this.lvAngajati_DoubleClick);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(198, 316);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(418, 318);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(637, 344);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(115, 46);
            this.btnVerificare.TabIndex = 3;
            this.btnVerificare.Text = "Vezi daca au companii";
            this.btnVerificare.UseVisualStyleBackColor = true;
            this.btnVerificare.Click += new System.EventHandler(this.btnVerificare_Click);
            // 
            // btnXLM
            // 
            this.btnXLM.Location = new System.Drawing.Point(103, 332);
            this.btnXLM.Name = "btnXLM";
            this.btnXLM.Size = new System.Drawing.Size(75, 23);
            this.btnXLM.TabIndex = 4;
            this.btnXLM.Text = "XLM";
            this.btnXLM.UseVisualStyleBackColor = true;
            this.btnXLM.Click += new System.EventHandler(this.btnXLM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXLM);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.lvAngajati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAngajati;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnXLM;
    }
}

