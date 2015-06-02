namespace Lab5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outlineBox = new System.Windows.Forms.CheckBox();
            this.fillBox = new System.Windows.Forms.CheckBox();
            this.penWidthList = new System.Windows.Forms.ListBox();
            this.fillColorList = new System.Windows.Forms.ListBox();
            this.penColorList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outlineBox);
            this.panel1.Controls.Add(this.fillBox);
            this.panel1.Controls.Add(this.penWidthList);
            this.panel1.Controls.Add(this.fillColorList);
            this.panel1.Controls.Add(this.penColorList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 188);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fill Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pen Color";
            // 
            // outlineBox
            // 
            this.outlineBox.AutoSize = true;
            this.outlineBox.Location = new System.Drawing.Point(335, 143);
            this.outlineBox.Name = "outlineBox";
            this.outlineBox.Size = new System.Drawing.Size(59, 17);
            this.outlineBox.TabIndex = 9;
            this.outlineBox.Text = "Outline";
            this.outlineBox.UseVisualStyleBackColor = true;
            // 
            // fillBox
            // 
            this.fillBox.AutoSize = true;
            this.fillBox.Location = new System.Drawing.Point(335, 117);
            this.fillBox.Name = "fillBox";
            this.fillBox.Size = new System.Drawing.Size(38, 17);
            this.fillBox.TabIndex = 8;
            this.fillBox.Text = "Fill";
            this.fillBox.UseVisualStyleBackColor = true;
            // 
            // penWidthList
            // 
            this.penWidthList.FormattingEnabled = true;
            this.penWidthList.Location = new System.Drawing.Point(482, 31);
            this.penWidthList.Name = "penWidthList";
            this.penWidthList.Size = new System.Drawing.Size(93, 134);
            this.penWidthList.TabIndex = 7;
            // 
            // fillColorList
            // 
            this.fillColorList.FormattingEnabled = true;
            this.fillColorList.Location = new System.Drawing.Point(376, 32);
            this.fillColorList.Name = "fillColorList";
            this.fillColorList.Size = new System.Drawing.Size(55, 69);
            this.fillColorList.TabIndex = 6;
            // 
            // penColorList
            // 
            this.penColorList.FormattingEnabled = true;
            this.penColorList.Location = new System.Drawing.Point(281, 32);
            this.penColorList.Name = "penColorList";
            this.penColorList.Size = new System.Drawing.Size(57, 69);
            this.penColorList.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.textButton);
            this.groupBox1.Controls.Add(this.ellipseButton);
            this.groupBox1.Controls.Add(this.rectangleButton);
            this.groupBox1.Controls.Add(this.lineButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(92, 116);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(150, 60);
            this.textBox.TabIndex = 4;
            // 
            // textButton
            // 
            this.textButton.AutoSize = true;
            this.textButton.Location = new System.Drawing.Point(24, 88);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(46, 17);
            this.textButton.TabIndex = 3;
            this.textButton.TabStop = true;
            this.textButton.Text = "Text";
            this.textButton.UseVisualStyleBackColor = true;
            // 
            // ellipseButton
            // 
            this.ellipseButton.AutoSize = true;
            this.ellipseButton.Location = new System.Drawing.Point(24, 65);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(55, 17);
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.TabStop = true;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Location = new System.Drawing.Point(24, 42);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(74, 17);
            this.rectangleButton.TabIndex = 1;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = true;
            this.lineButton.Location = new System.Drawing.Point(24, 19);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(45, 17);
            this.lineButton.TabIndex = 0;
            this.lineButton.TabStop = true;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 212);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab 5 by Luke Poitras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox outlineBox;
        private System.Windows.Forms.CheckBox fillBox;
        private System.Windows.Forms.ListBox penWidthList;
        private System.Windows.Forms.ListBox fillColorList;
        private System.Windows.Forms.ListBox penColorList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton textButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

