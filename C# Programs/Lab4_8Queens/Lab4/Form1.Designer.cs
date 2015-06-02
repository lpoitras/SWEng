namespace Lab4
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
            this.button1 = new System.Windows.Forms.Button();
            this.hintsBox = new System.Windows.Forms.CheckBox();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // hintsBox
            // 
            this.hintsBox.AutoSize = true;
            this.hintsBox.Location = new System.Drawing.Point(12, 36);
            this.hintsBox.Name = "hintsBox";
            this.hintsBox.Size = new System.Drawing.Size(50, 17);
            this.hintsBox.TabIndex = 1;
            this.hintsBox.Text = "Hints";
            this.hintsBox.UseVisualStyleBackColor = true;
            this.hintsBox.CheckedChanged += new System.EventHandler(this.hintsBox_CheckedChanged);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(246, 41);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(35, 13);
            this.number.TabIndex = 3;
            this.number.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(619, 597);
            this.Controls.Add(this.number);
            this.Controls.Add(this.hintsBox);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox hintsBox;
        private System.Windows.Forms.Label number;
    }
}

