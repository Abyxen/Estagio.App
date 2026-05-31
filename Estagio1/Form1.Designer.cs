namespace Estagio1
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table Selection";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "User_id", "User_Location" });
            comboBox1.Location = new Point(197, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 26);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 2;
            label1.Text = "Select Table";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(366, 26);
            button1.Name = "button1";
            button1.Size = new Size(119, 34);
            button1.TabIndex = 1;
            button1.Text = "Load Table";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            groupBox2.Location = new Point(15, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(935, 119);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 57);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 3;
            label2.Text = "Enter ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 28);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(709, 47);
            button4.Name = "button4";
            button4.Size = new Size(140, 39);
            button4.TabIndex = 2;
            button4.Text = "🔄  Restore";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(530, 47);
            button3.Name = "button3";
            button3.Size = new Size(140, 39);
            button3.TabIndex = 1;
            button3.Text = "🗑 Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(364, 47);
            button2.Name = "button2";
            button2.Size = new Size(140, 39);
            button2.TabIndex = 0;
            button2.Text = " 🔎 Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Unispace", 11.25F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(937, 273);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(914, 219);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_27_222906;
            ClientSize = new Size(967, 557);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
    }
}
