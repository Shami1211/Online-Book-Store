using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginbtnA_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text == "Password")
            {
                Books Obj = new Books();
                Obj.Show();
                this.Hide();

            }
        }
    }
}
