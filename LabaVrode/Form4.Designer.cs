namespace LabaVrode
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            groupBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBindingSource1 = new BindingSource(components);
            studentBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            surenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource1 = new BindingSource(components);
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 417);
            button1.Name = "button1";
            button1.Size = new Size(244, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить группу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 417);
            button2.Name = "button2";
            button2.Size = new Size(744, 23);
            button2.TabIndex = 3;
            button2.Text = "Добавить студента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBindingSource
            // 
            groupBindingSource.DataSource = typeof(Data.Group);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView2.DataSource = groupBindingSource;
            dataGridView2.Location = new Point(12, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(278, 396);
            dataGridView2.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // groupBindingSource1
            // 
            groupBindingSource1.DataSource = typeof(Data.Group);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Data.Student);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, surenameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, birthDayDataGridViewTextBoxColumn, groupIdDataGridViewTextBoxColumn, groupDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource1;
            dataGridView1.Location = new Point(296, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(744, 396);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surenameDataGridViewTextBoxColumn
            // 
            surenameDataGridViewTextBoxColumn.DataPropertyName = "Surename";
            surenameDataGridViewTextBoxColumn.HeaderText = "Surename";
            surenameDataGridViewTextBoxColumn.Name = "surenameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            groupDataGridViewTextBoxColumn.HeaderText = "Group";
            groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Data.Student);
            // 
            // button3
            // 
            button3.Location = new Point(296, 446);
            button3.Name = "button3";
            button3.Size = new Size(369, 23);
            button3.TabIndex = 6;
            button3.Text = "Добавить предмет";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(671, 446);
            button4.Name = "button4";
            button4.Size = new Size(369, 23);
            button4.TabIndex = 7;
            button4.Text = "Список всех предметов";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 502);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private BindingSource groupBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource groupBindingSource1;
        private BindingSource studentBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn surenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource1;
        private Button button3;
        private Button button4;
    }
}