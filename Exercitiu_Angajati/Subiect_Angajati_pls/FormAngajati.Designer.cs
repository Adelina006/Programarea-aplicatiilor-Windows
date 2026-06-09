namespace Subiect_Angajati_pls
{
    partial class FormAngajati
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
            this.components = new System.ComponentModel.Container();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbCompanie = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(285, 64);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 0;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(285, 153);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 1;
            // 
            // cmbCompanie
            // 
            this.cmbCompanie.FormattingEnabled = true;
            this.cmbCompanie.Location = new System.Drawing.Point(286, 232);
            this.cmbCompanie.Name = "cmbCompanie";
            this.cmbCompanie.Size = new System.Drawing.Size(121, 24);
            this.cmbCompanie.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(286, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbCompanie);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtNume);
            this.Name = "FormAngajati";
            this.Text = "FormAngajati";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbCompanie;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}