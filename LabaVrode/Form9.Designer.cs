namespace LabaVrode
{
    partial class Form9
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(259, 418);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название предмета";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Оценка";
            columnHeader2.Width = 70;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(277, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(443, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(277, 51);
            button1.Name = "button1";
            button1.Size = new Size(317, 23);
            button1.TabIndex = 3;
            button1.Text = "Выставить оценку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
    }
}