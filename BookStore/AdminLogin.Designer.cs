namespace BookStore
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            UPassTb = new TextBox();
            label3 = new Label();
            LoginbtnA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 252);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UPassTb
            // 
            UPassTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UPassTb.Location = new Point(320, 116);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '*';
            UPassTb.Size = new Size(358, 34);
            UPassTb.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(320, 73);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // LoginbtnA
            // 
            LoginbtnA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginbtnA.Location = new Point(425, 190);
            LoginbtnA.Name = "LoginbtnA";
            LoginbtnA.Size = new Size(120, 43);
            LoginbtnA.TabIndex = 11;
            LoginbtnA.Text = "Login";
            LoginbtnA.UseVisualStyleBackColor = true;
            LoginbtnA.Click += LoginbtnA_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 312);
            Controls.Add(LoginbtnA);
            Controls.Add(label3);
            Controls.Add(UPassTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox UPassTb;
        private Label label3;
        private Button LoginbtnA;
    }
}