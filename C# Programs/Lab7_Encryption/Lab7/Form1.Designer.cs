namespace Lab7
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileText = new System.Windows.Forms.TextBox();
            this.keyStringText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Key:";
            // 
            // openFileText
            // 
            this.openFileText.Location = new System.Drawing.Point(38, 39);
            this.openFileText.Name = "openFileText";
            this.openFileText.Size = new System.Drawing.Size(248, 20);
            this.openFileText.TabIndex = 2;
            // 
            // keyStringText
            // 
            this.keyStringText.Location = new System.Drawing.Point(38, 85);
            this.keyStringText.Name = "keyStringText";
            this.keyStringText.Size = new System.Drawing.Size(100, 20);
            this.keyStringText.TabIndex = 3;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(38, 142);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(139, 142);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackgroundImage = global::Lab7.Properties.Resources.OpenPH;
            this.openFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openFileButton.Location = new System.Drawing.Point(315, 30);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(39, 36);
            this.openFileButton.TabIndex = 6;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(395, 204);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.keyStringText);
            this.Controls.Add(this.openFileText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox openFileText;
        private System.Windows.Forms.TextBox keyStringText;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button openFileButton;
    }
}

