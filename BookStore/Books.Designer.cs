namespace BookStore
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            BTitleTb = new TextBox();
            BCatCb = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            BautTb = new TextBox();
            QtyTb = new TextBox();
            label8 = new Label();
            PriceTb = new TextBox();
            label10 = new Label();
            SaveBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            BookDGV = new DataGridView();
            label11 = new Label();
            CatCbSearchCb = new ComboBox();
            button5 = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 65, 115);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 659);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 600);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 65, 115);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(-2, 334);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 64);
            panel4.TabIndex = 15;
            panel4.Paint += panel4_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 13);
            label4.Name = "label4";
            label4.Size = new Size(141, 35);
            label4.TabIndex = 2;
            label4.Text = "Dashboard";
            label4.Click += label4_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 65, 115);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(-2, 266);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 64);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 15);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 2;
            label3.Text = "Users";
            label3.Click += label3_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, 198);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 64);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(112, 15);
            label2.Name = "label2";
            label2.Size = new Size(86, 35);
            label2.TabIndex = 1;
            label2.Text = "Books";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(1133, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 36);
            label5.TabIndex = 11;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(403, 2);
            label1.Name = "label1";
            label1.Size = new Size(560, 54);
            label1.TabIndex = 12;
            label1.Text = "Welcome To Book Shop";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(243, 82);
            label6.Name = "label6";
            label6.Size = new Size(56, 30);
            label6.TabIndex = 14;
            label6.Text = "Title";
            label6.Click += label6_Click;
            // 
            // BTitleTb
            // 
            BTitleTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitleTb.Location = new Point(243, 122);
            BTitleTb.Margin = new Padding(3, 4, 3, 4);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(174, 34);
            BTitleTb.TabIndex = 13;
            // 
            // BCatCb
            // 
            BCatCb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BCatCb.ForeColor = SystemColors.MenuText;
            BCatCb.FormattingEnabled = true;
            BCatCb.IntegralHeight = false;
            BCatCb.ItemHeight = 28;
            BCatCb.Items.AddRange(new object[] { "Programming", "Networking", "Mathematics", "Physics", "Novels", "Biography" });
            BCatCb.Location = new Point(609, 122);
            BCatCb.Margin = new Padding(3, 4, 3, 4);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(183, 36);
            BCatCb.TabIndex = 19;
            BCatCb.Text = "Select Categories";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(427, 80);
            label9.Name = "label9";
            label9.Size = new Size(83, 30);
            label9.TabIndex = 20;
            label9.Text = "Author";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(609, 80);
            label7.Name = "label7";
            label7.Size = new Size(116, 30);
            label7.TabIndex = 21;
            label7.Text = "Categories";
            // 
            // BautTb
            // 
            BautTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BautTb.Location = new Point(427, 122);
            BautTb.Margin = new Padding(3, 4, 3, 4);
            BautTb.Name = "BautTb";
            BautTb.Size = new Size(174, 34);
            BautTb.TabIndex = 22;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.Location = new Point(803, 124);
            QtyTb.Margin = new Padding(3, 4, 3, 4);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(156, 34);
            QtyTb.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(803, 82);
            label8.Name = "label8";
            label8.Size = new Size(99, 30);
            label8.TabIndex = 23;
            label8.Text = "Quantity";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(968, 124);
            PriceTb.Margin = new Padding(3, 4, 3, 4);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(144, 34);
            PriceTb.TabIndex = 26;
            PriceTb.TextChanged += textBox4_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(968, 82);
            label10.Name = "label10";
            label10.Size = new Size(61, 30);
            label10.TabIndex = 25;
            label10.Text = "Price";
            label10.Click += label10_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(26, 65, 115);
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(379, 193);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(120, 43);
            SaveBtn.TabIndex = 27;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(26, 65, 115);
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(552, 193);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(120, 43);
            EditBtn.TabIndex = 28;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(710, 193);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(120, 43);
            DeleteBtn.TabIndex = 29;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(26, 65, 115);
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(865, 193);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(120, 43);
            ResetBtn.TabIndex = 30;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // BookDGV
            // 
            BookDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(5);
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BookDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Cursor = Cursors.Hand;
            BookDGV.GridColor = Color.White;
            BookDGV.Location = new Point(241, 347);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 29;
            BookDGV.Size = new Size(869, 298);
            BookDGV.TabIndex = 31;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(543, 254);
            label11.Name = "label11";
            label11.Size = new Size(276, 34);
            label11.TabIndex = 32;
            label11.Text = "Books Details List";
            // 
            // CatCbSearchCb
            // 
            CatCbSearchCb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CatCbSearchCb.ForeColor = SystemColors.MenuText;
            CatCbSearchCb.FormattingEnabled = true;
            CatCbSearchCb.IntegralHeight = false;
            CatCbSearchCb.ItemHeight = 28;
            CatCbSearchCb.Items.AddRange(new object[] { "Programming", "Networking", "Mathematics", "Physics", "Novels", "Biography" });
            CatCbSearchCb.Location = new Point(479, 299);
            CatCbSearchCb.Margin = new Padding(3, 4, 3, 4);
            CatCbSearchCb.Name = "CatCbSearchCb";
            CatCbSearchCb.Size = new Size(277, 36);
            CatCbSearchCb.TabIndex = 33;
            CatCbSearchCb.Text = "Filter by Categories";
            CatCbSearchCb.SelectedIndexChanged += CatCbSearchCb_SelectedIndexChanged;
            CatCbSearchCb.SelectionChangeCommitted += CatCbSearchCb_SelectionChangeCommitted;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(26, 65, 115);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(763, 295);
            button5.Name = "button5";
            button5.Size = new Size(120, 43);
            button5.TabIndex = 34;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(1091, 0);
            label12.Name = "label12";
            label12.Size = new Size(34, 36);
            label12.TabIndex = 35;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 658);
            Controls.Add(label12);
            Controls.Add(button5);
            Controls.Add(CatCbSearchCb);
            Controls.Add(label11);
            Controls.Add(BookDGV);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(PriceTb);
            Controls.Add(label10);
            Controls.Add(QtyTb);
            Controls.Add(label8);
            Controls.Add(BautTb);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(BCatCb);
            Controls.Add(label6);
            Controls.Add(BTitleTb);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Books_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private TextBox BTitleTb;
        private ComboBox BCatCb;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label7;
        private TextBox BautTb;
        private TextBox QtyTb;
        private Label label8;
        private TextBox PriceTb;
        private Label label10;
        private Button SaveBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private DataGridView BookDGV;
        private Label label11;
        private ComboBox CatCbSearchCb;
        private Button button5;
        private Label label12;
    }
}