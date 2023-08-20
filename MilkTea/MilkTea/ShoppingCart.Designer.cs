
namespace ShoppingCartNew
{
    partial class ShoppingCart
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboCategory = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            textBox1 = new TextBox();
            Employee = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(634, 637);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(950, 642);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Total :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1048, 642);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(1151, 703);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(22, 45);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(151, 28);
            comboCategory.TabIndex = 5;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(747, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(635, 526);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(677, 341);
            button2.Name = "button2";
            button2.Size = new Size(51, 29);
            button2.TabIndex = 7;
            button2.Text = "=>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(973, 47);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 8;
            // 
            // Employee
            // 
            Employee.AutoSize = true;
            Employee.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Employee.Location = new Point(848, 49);
            Employee.Name = "Employee";
            Employee.Size = new Size(103, 25);
            Employee.TabIndex = 9;
            Employee.Text = "Employee :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 707);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "label3";

            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 759);
            Controls.Add(label3);
            Controls.Add(Employee);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboCategory);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ShoppingCart";
            Text = "Form1";
            Load += ShoppingCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboCategory;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private TextBox textBox1;
        private Label Employee;
        private Label label3;
    }
}

