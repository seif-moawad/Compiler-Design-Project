
namespace WindowsFormsApp2
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
            this.Texteditor = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texteditor
            // 
            this.Texteditor.BackColor = System.Drawing.SystemColors.Desktop;
            this.Texteditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texteditor.ForeColor = System.Drawing.SystemColors.Window;
            this.Texteditor.Location = new System.Drawing.Point(0, 1);
            this.Texteditor.Multiline = true;
            this.Texteditor.Name = "Texteditor";
            this.Texteditor.Size = new System.Drawing.Size(483, 448);
            this.Texteditor.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(482, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 204);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(414, 1);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(69, 42);
            this.Run.TabIndex = 2;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Texteditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texteditor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Run;
    }
}

