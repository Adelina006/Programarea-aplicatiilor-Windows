namespace Subiect2025_gestiune_angajati
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
            this.btnAdaugareAngajat = new System.Windows.Forms.Button();
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAdaugareAngajat
            // 
            this.btnAdaugareAngajat.Location = new System.Drawing.Point(110, 285);
            this.btnAdaugareAngajat.Name = "btnAdaugareAngajat";
            this.btnAdaugareAngajat.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugareAngajat.TabIndex = 0;
            this.btnAdaugareAngajat.Text = "Adauga Angajat";
            this.btnAdaugareAngajat.UseVisualStyleBackColor = true;
            this.btnAdaugareAngajat.Click += new System.EventHandler(this.btnAdaugareAngajat_Click);
            // 
            // lvAngajati
            // 
            this.lvAngajati.FullRowSelect = true;
            this.lvAngajati.GridLines = true;
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(27, 29);
            this.lvAngajati.MultiSelect = false;
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(642, 143);
            this.lvAngajati.TabIndex = 1;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.DoubleClick += new System.EventHandler(this.lvAngajati_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAngajati);
            this.Controls.Add(this.btnAdaugareAngajat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugareAngajat;
        private System.Windows.Forms.ListView lvAngajati;
    }
}

