namespace Bot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(16, 227);
            button1.Name = "button1";
            button1.Size = new Size(193, 37);
            button1.TabIndex = 0;
            button1.Text = "TAKİP ET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(237, 227);
            button2.Name = "button2";
            button2.Size = new Size(193, 37);
            button2.TabIndex = 1;
            button2.Text = "SON GÖNDERİ BEĞENİ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(16, 281);
            button3.Name = "button3";
            button3.Size = new Size(193, 37);
            button3.TabIndex = 3;
            button3.Text = "SON GÖNDERİ YORUM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 118);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 4;
            label1.Text = "KULLANICI ADI";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(397, -7);
            button4.Name = "button4";
            button4.Size = new Size(53, 54);
            button4.TabIndex = 5;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(237, 281);
            button5.Name = "button5";
            button5.Size = new Size(193, 37);
            button5.TabIndex = 6;
            button5.Text = "NATRO ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(16, 338);
            button6.Name = "button6";
            button6.Size = new Size(193, 37);
            button6.TabIndex = 7;
            button6.Text = "Instagram";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 449);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOLYYTHEO.EXE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}