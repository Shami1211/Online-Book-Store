namespace BookStore
{
    partial class Bil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bil));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox5 = new PictureBox();
            BookDGV = new DataGridView();
            label11 = new Label();
            Printbtn = new Button();
            Resetbtn = new Button();
            Addbillbtn = new Button();
            QtyTb = new TextBox();
            label9 = new Label();
            label6 = new Label();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            PriceTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ClientNameTb = new TextBox();
            label4 = new Label();
            TotalLbl = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox2 = new PictureBox();
            UserNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(13, 639);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // BookDGV
            // 
            BookDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(5);
            BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BookDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Cursor = Cursors.Hand;
            BookDGV.GridColor = Color.White;
            BookDGV.Location = new Point(96, 388);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 29;
            BookDGV.Size = new Size(475, 298);
            BookDGV.TabIndex = 71;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(195, 347);
            label11.Name = "label11";
            label11.Size = new Size(232, 29);
            label11.TabIndex = 70;
            label11.Text = "Books Details List";
            // 
            // Printbtn
            // 
            Printbtn.BackColor = Color.FromArgb(26, 65, 115);
            Printbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Printbtn.ForeColor = Color.White;
            Printbtn.Location = new Point(873, 553);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(120, 43);
            Printbtn.TabIndex = 69;
            Printbtn.Text = "Print";
            Printbtn.UseVisualStyleBackColor = false;
            Printbtn.Click += Printbtn_Click;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.FromArgb(26, 65, 115);
            Resetbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Resetbtn.ForeColor = Color.White;
            Resetbtn.Location = new Point(352, 269);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(120, 43);
            Resetbtn.TabIndex = 67;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Addbillbtn
            // 
            Addbillbtn.BackColor = Color.FromArgb(26, 65, 115);
            Addbillbtn.Cursor = Cursors.Hand;
            Addbillbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Addbillbtn.ForeColor = Color.White;
            Addbillbtn.Location = new Point(165, 269);
            Addbillbtn.Name = "Addbillbtn";
            Addbillbtn.Size = new Size(172, 43);
            Addbillbtn.TabIndex = 66;
            Addbillbtn.Text = "Add To Bill";
            Addbillbtn.UseVisualStyleBackColor = false;
            Addbillbtn.Click += Addbillbtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.Location = new Point(352, 121);
            QtyTb.Margin = new Padding(3, 4, 3, 4);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(219, 34);
            QtyTb.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(352, 79);
            label9.Name = "label9";
            label9.Size = new Size(99, 30);
            label9.TabIndex = 60;
            label9.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(128, 81);
            label6.Name = "label6";
            label6.Size = new Size(128, 30);
            label6.TabIndex = 59;
            label6.Text = "Book Name";
            // 
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitleTb.Location = new Point(128, 121);
            BTitleTb.Margin = new Padding(3, 4, 3, 4);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(209, 34);
            BTitleTb.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(403, 1);
            label1.Name = "label1";
            label1.Size = new Size(560, 54);
            label1.TabIndex = 57;
            label1.Text = "Welcome To Book Shop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 65, 115);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 700);
            panel1.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(1244, -1);
            label5.Name = "label5";
            label5.Size = new Size(34, 36);
            label5.TabIndex = 56;
            label5.Text = "X";
            // 
            // BillDGV
            // 
            BillDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(5);
            BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            BillDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Cursor = Cursors.Hand;
            BillDGV.GridColor = Color.White;
            BillDGV.Location = new Point(587, 121);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.RowTemplate.Height = 29;
            BillDGV.Size = new Size(679, 343);
            BillDGV.TabIndex = 72;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(352, 209);
            PriceTb.Margin = new Padding(3, 4, 3, 4);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(219, 34);
            PriceTb.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(352, 167);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 75;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(128, 169);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 74;
            label3.Text = "Client Name";
            // 
            // ClientNameTb
            // 
            ClientNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientNameTb.Location = new Point(128, 209);
            ClientNameTb.Margin = new Padding(3, 4, 3, 4);
            ClientNameTb.Name = "ClientNameTb";
            ClientNameTb.Size = new Size(209, 34);
            ClientNameTb.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(859, 78);
            label4.Name = "label4";
            label4.Size = new Size(134, 29);
            label4.TabIndex = 78;
            label4.Text = "Books Bill";
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLbl.Location = new Point(838, 496);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(75, 29);
            TotalLbl.TabIndex = 79;
            TotalLbl.Text = "Total";
            TotalLbl.Click += label7_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(93, 3);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLbl.Location = new Point(165, 21);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(120, 30);
            UserNameLbl.TabIndex = 80;
            UserNameLbl.Text = "User Name";
            // 
            // Bil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1278, 698);
            Controls.Add(UserNameLbl);
            Controls.Add(pictureBox2);
            Controls.Add(TotalLbl);
            Controls.Add(label4);
            Controls.Add(PriceTb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ClientNameTb);
            Controls.Add(BillDGV);
            Controls.Add(BookDGV);
            Controls.Add(label11);
            Controls.Add(Printbtn);
            Controls.Add(Resetbtn);
            Controls.Add(Addbillbtn);
            Controls.Add(QtyTb);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(BTitleTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bil";
            Load += Bil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private DataGridView BookDGV;
        private Label label11;
        private Button Printbtn;
        private Button Resetbtn;
        private Button Addbillbtn;
        private TextBox QtyTb;
        private Label label9;
        private Label label6;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox PriceTb;
        private Label label2;
        private Label label3;
        private TextBox ClientNameTb;
        private Label label4;
        private Label TotalLbl;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox2;
        private Label UserNameLbl;
    }
}