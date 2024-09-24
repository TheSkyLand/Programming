namespace WinFormsApp2
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
            button3 = new Button();
            textBox1 = new TextBox();
            sumBox = new ListBox();
            meanBox = new ListBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 397);
            button1.Name = "button1";
            button1.Size = new Size(169, 41);
            button1.TabIndex = 1;
            button1.Text = "Очистка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 397);
            button2.Name = "button2";
            button2.Size = new Size(169, 41);
            button2.TabIndex = 2;
            button2.Text = "Массив по умолчанию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(619, 397);
            button3.Name = "button3";
            button3.Size = new Size(169, 41);
            button3.TabIndex = 3;
            button3.Text = "Вычислить";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 179);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 212);
            textBox1.TabIndex = 4;
            textBox1.Text = "-15,1\r\n0,8\r\n32,3\r\n7,5\r\n-1,5\r\n2,4\r\n-6,3\r\n15,5";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // sumBox
            // 
            sumBox.FormattingEnabled = true;
            sumBox.ItemHeight = 15;
            sumBox.Location = new Point(316, 177);
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(169, 214);
            sumBox.TabIndex = 5;
            sumBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // meanBox
            // 
            meanBox.FormattingEnabled = true;
            meanBox.ItemHeight = 15;
            meanBox.Location = new Point(619, 177);
            meanBox.Name = "meanBox";
            meanBox.Size = new Size(169, 214);
            meanBox.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(68, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(113, 214);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(meanBox);
            Controls.Add(sumBox);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private ListBox sumBox;
        private ListBox meanBox;
        private ListBox listBox1;
    }
}