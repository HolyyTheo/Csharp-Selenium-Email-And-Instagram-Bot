﻿namespace Bot
{
    partial class insta
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(615, 46);
            button1.Name = "button1";
            button1.Size = new Size(196, 87);
            button1.TabIndex = 0;
            button1.Text = "ÇALIŞTIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 148);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1431, 820);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // insta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 980);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "insta";
            Text = "insta";
            Load += insta_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
    }
}