namespace BibleVerse2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.verseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookInput = new System.Windows.Forms.TextBox();
            this.bookLabel = new System.Windows.Forms.Label();
            this.ReferenceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chapterBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(620, 141);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Verse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verseBox
            // 
            this.verseBox.Location = new System.Drawing.Point(12, 270);
            this.verseBox.Name = "verseBox";
            this.verseBox.Size = new System.Drawing.Size(141, 20);
            this.verseBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // bookInput
            // 
            this.bookInput.Location = new System.Drawing.Point(12, 179);
            this.bookInput.Name = "bookInput";
            this.bookInput.Size = new System.Drawing.Size(141, 20);
            this.bookInput.TabIndex = 6;
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Location = new System.Drawing.Point(9, 163);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(38, 13);
            this.bookLabel.TabIndex = 7;
            this.bookLabel.Text = "Book: ";
            // 
            // ReferenceLabel
            // 
            this.ReferenceLabel.AutoSize = true;
            this.ReferenceLabel.Location = new System.Drawing.Point(13, 254);
            this.ReferenceLabel.Name = "ReferenceLabel";
            this.ReferenceLabel.Size = new System.Drawing.Size(34, 13);
            this.ReferenceLabel.TabIndex = 8;
            this.ReferenceLabel.Text = "Verse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chapter";
            // 
            // chapterBox
            // 
            this.chapterBox.Location = new System.Drawing.Point(15, 222);
            this.chapterBox.Name = "chapterBox";
            this.chapterBox.Size = new System.Drawing.Size(141, 20);
            this.chapterBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.chapterBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReferenceLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.bookInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verseBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox verseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookInput;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Label ReferenceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chapterBox;
    }
}

