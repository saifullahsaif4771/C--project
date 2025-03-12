namespace cSharp_project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            totIncome = new Label();
            textBox1 = new TextBox();
            cashierCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(798, 587);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(347, 138);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(302, 42);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(158, 37);
            lblDateTime.TabIndex = 15;
            lblDateTime.Text = "LIVE TIME :";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.a5de6f7a8f50967b88bfb2314fbce8b7dc6dfa005fadec0a2bdec08eb9f4ae3d;
            pictureBox2.Location = new Point(591, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 185);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 12;
            label1.Text = "totOrder";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 182);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // totIncome
            // 
            totIncome.AutoSize = true;
            totIncome.Location = new Point(510, 185);
            totIncome.Name = "totIncome";
            totIncome.Size = new Size(81, 15);
            totIncome.TabIndex = 5;
            totIncome.Text = "Total Income :";
            totIncome.Click += totIncome_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(609, 182);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.ReadOnlyChanged += textBox1_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cashierCount
            // 
            cashierCount.AutoSize = true;
            cashierCount.Location = new Point(46, 144);
            cashierCount.Name = "cashierCount";
            cashierCount.Size = new Size(80, 15);
            cashierCount.TabIndex = 3;
            cashierCount.Text = "Total Cashier :";
            cashierCount.Click += label1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(lblDateTime);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(totIncome);
            Controls.Add(pictureBox2);
            Controls.Add(cashierCount);
            Controls.Add(pictureBox3);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label totIncome;
        private TextBox textBox1;
        private Label cashierCount;
    }
}