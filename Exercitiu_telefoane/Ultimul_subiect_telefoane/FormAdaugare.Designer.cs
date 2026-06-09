namespace Ultimul_subiect_telefoane
{
    partial class FormAdaugare
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numStoc = new System.Windows.Forms.NumericUpDown();
            this.numPret = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbProducatori = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numStoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(313, 39);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 0;
            // 
            // numStoc
            // 
            this.numStoc.Location = new System.Drawing.Point(313, 89);
            this.numStoc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStoc.Name = "numStoc";
            this.numStoc.Size = new System.Drawing.Size(120, 22);
            this.numStoc.TabIndex = 1;
            // 
            // numPret
            // 
            this.numPret.Location = new System.Drawing.Point(313, 143);
            this.numPret.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPret.Name = "numPret";
            this.numPret.Size = new System.Drawing.Size(120, 22);
            this.numPret.TabIndex = 2;
            this.numPret.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(313, 200);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 3;
            // 
            // cmbProducatori
            // 
            this.cmbProducatori.FormattingEnabled = true;
            this.cmbProducatori.Location = new System.Drawing.Point(312, 254);
            this.cmbProducatori.Name = "cmbProducatori";
            this.cmbProducatori.Size = new System.Drawing.Size(121, 24);
            this.cmbProducatori.TabIndex = 4;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(313, 311);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 5;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cmbProducatori);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.numPret);
            this.Controls.Add(this.numStoc);
            this.Controls.Add(this.txtModel);
            this.Name = "FormAdaugare";
            this.Text = "FormAdaugare";
            ((System.ComponentModel.ISupportInitialize)(this.numStoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numStoc;
        private System.Windows.Forms.NumericUpDown numPret;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbProducatori;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}