namespace BookStore
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            Myprogress = new ProgressBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            PrasantageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 25);
            label1.Name = "label1";
            label1.Size = new Size(371, 27);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Management System";
            label1.Click += label1_Click;
            // 
            // Myprogress
            // 
            Myprogress.ForeColor = Color.Blue;
            Myprogress.Location = new Point(0, 338);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(553, 17);
            Myprogress.TabIndex = 2;
            Myprogress.Click += Myprogress_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 234);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(2, 316);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 4;
            label2.Text = "Loading...";
            label2.Click += label2_Click;
            // 
            // PrasantageLbl
            // 
            PrasantageLbl.AutoSize = true;
            PrasantageLbl.BackColor = Color.White;
            PrasantageLbl.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            PrasantageLbl.ForeColor = SystemColors.ControlDarkDark;
            PrasantageLbl.Location = new Point(98, 314);
            PrasantageLbl.Name = "PrasantageLbl";
            PrasantageLbl.RightToLeft = RightToLeft.Yes;
            PrasantageLbl.Size = new Size(25, 21);
            PrasantageLbl.TabIndex = 5;
            PrasantageLbl.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 354);
            Controls.Add(PrasantageLbl);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar Myprogress;
        private PictureBox pictureBox1;
        private Label label2;
        private Label PrasantageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}