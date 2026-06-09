namespace Ultimul_subiect_telefoane
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
            this.dgvTelefoane = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoane)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTelefoane
            // 
            this.dgvTelefoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefoane.Location = new System.Drawing.Point(12, 33);
            this.dgvTelefoane.MultiSelect = false;
            this.dgvTelefoane.Name = "dgvTelefoane";
            this.dgvTelefoane.ReadOnly = true;
            this.dgvTelefoane.RowHeadersWidth = 51;
            this.dgvTelefoane.RowTemplate.Height = 24;
            this.dgvTelefoane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefoane.Size = new System.Drawing.Size(752, 313);
            this.dgvTelefoane.TabIndex = 0;
            this.dgvTelefoane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefoane_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.stocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click_1);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // stocToolStripMenuItem
            // 
            this.stocToolStripMenuItem.Name = "stocToolStripMenuItem";
            this.stocToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stocToolStripMenuItem.Text = "Stoc";
            this.stocToolStripMenuItem.Click += new System.EventHandler(this.stocToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTelefoane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefoane)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelefoane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocToolStripMenuItem;
    }
}

