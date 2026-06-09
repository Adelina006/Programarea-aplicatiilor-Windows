namespace Subiet_studenti
{
    partial class TextBoxEtichetat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 16);
            this.label.TabIndex = 0;
            this.label.Text = "label1";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(99, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(122, 22);
            this.textBox.TabIndex = 1;
            // 
            // TextBoxEtichetat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "TextBoxEtichetat";
            this.Size = new System.Drawing.Size(269, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
    }
}
