namespace Lab2
{
    partial class TabulateFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabulateFunc));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 3;
            label1.Text = "Початок відрізку";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 23);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Кінець відрізку";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 23);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 7;
            label3.Text = "Крок";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 30);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(299, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(64, 27);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 7);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Крок";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 7);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Кінець відрізку";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 7);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 5;
            label6.Text = "Початок відрізку";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(323, 317);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(463, 29);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 7;
            label7.Text = "y = sin(x) - 1/x";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(463, 76);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 8;
            button1.Text = "Протабулювати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TabulateFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TabulateFunc";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button1;
    }
}
