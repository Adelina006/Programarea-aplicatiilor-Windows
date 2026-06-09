namespace Subiet_studenti
{
    partial class FormEditare
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtMatricol = new System.Windows.Forms.TextBox();
            this.txtMedie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 359);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(221, 98);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtMatricol
            // 
            this.txtMatricol.Location = new System.Drawing.Point(230, 172);
            this.txtMatricol.Name = "txtMatricol";
            this.txtMatricol.Size = new System.Drawing.Size(100, 22);
            this.txtMatricol.TabIndex = 5;
            // 
            // txtMedie
            // 
            this.txtMedie.Location = new System.Drawing.Point(231, 261);
            this.txtMedie.Name = "txtMedie";
            this.txtMedie.Size = new System.Drawing.Size(100, 22);
            this.txtMedie.TabIndex = 6;
            // 
            // FormEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMedie);
            this.Controls.Add(this.txtMatricol);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnOk);
            this.Name = "FormEditare";
            this.Text = "FormEditare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtMatricol;
        private System.Windows.Forms.TextBox txtMedie;
    }
}