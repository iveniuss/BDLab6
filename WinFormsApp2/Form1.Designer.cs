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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Игры", "Игроки", "Разработчики", "Издатели", "Теги", "Системные требования" });
            comboBox1.Location = new Point(22, 26);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            comboBox1.MouseClick += comboBox1_MouseClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 107);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(646, 747);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(529, 26);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(724, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 51);
            label1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Location = new Point(724, 107);
            richTextBox1.Margin = new Padding(6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(509, 501);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(724, 619);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 45);
            label2.TabIndex = 5;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(724, 670);
            richTextBox2.Margin = new Padding(6);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(509, 184);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(22, 866);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 7;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Add_Click;
            // 
            // button3
            // 
            button3.Location = new Point(173, 866);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(139, 49);
            button3.TabIndex = 8;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(724, 869);
            button4.Name = "button4";
            button4.Size = new Size(230, 46);
            button4.TabIndex = 9;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1027, 869);
            button5.Name = "button5";
            button5.Size = new Size(206, 46);
            button5.TabIndex = 10;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 960);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private RichTextBox richTextBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
