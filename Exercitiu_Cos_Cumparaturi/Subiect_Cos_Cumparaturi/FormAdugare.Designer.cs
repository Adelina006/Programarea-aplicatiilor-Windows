namespace Subiect_Cos_Cumparaturi
{
    partial class FormAdugare
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.numCantitate = new System.Windows.Forms.NumericUpDown();
            this.numPret = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(350, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(350, 97);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 1;
            // 
            // numCantitate
            // 
            this.numCantitate.Location = new System.Drawing.Point(356, 166);
            this.numCantitate.Name = "numCantitate";
            this.numCantitate.Size = new System.Drawing.Size(120, 22);
            this.numCantitate.TabIndex = 2;
            // 
            // numPret
            // 
            this.numPret.Location = new System.Drawing.Point(351, 233);
            this.numPret.Name = "numPret";
            this.numPret.Size = new System.Drawing.Size(120, 22);
            this.numPret.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(288, 351);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAdugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numPret);
            this.Controls.Add(this.numCantitate);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtId);
            this.Name = "FormAdugare";
            this.Text = "FormAdugare";
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.NumericUpDown numCantitate;
        private System.Windows.Forms.NumericUpDown numPret;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}