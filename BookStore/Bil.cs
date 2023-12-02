using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Bil : Form
    {
        public Bil()
        {
            InitializeComponent();
            populate();
        }
        // Define the connection string for your SQL Server database
        SqlConnection Con = new SqlConnection(@"Data Source=MRDILA\SQLEXPRESS;Initial Catalog=Book;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        private void populate()
        {
            Con.Open();
            String query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                String query = "update BookTbl set Bqty = '" + newQty + "' where BId = " + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int n = 0, GrdTotal = 0;
        private void Addbillbtn_Click(object sender, EventArgs e)
        {

            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("No Enough Stock..");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "Total Price Rs: " + GrdTotal;
            }
        }
        int key = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if any rows are selected
            if (BookDGV.SelectedCells.Count > 0)
            {
                int selectedRowIndex = BookDGV.SelectedCells[0].RowIndex;

                BTitleTb.Text = BookDGV.Rows[selectedRowIndex].Cells[1].Value.ToString();
                //BautTb.Text = BookDGV.Rows[selectedRowIndex].Cells[2].Value.ToString();
                //BCatCb.SelectedItem = BookDGV.Rows[selectedRowIndex].Cells[3].Value.ToString();
                //QtyTb.Text = BookDGV.Rows[selectedRowIndex].Cells[4].Value.ToString();
                PriceTb.Text = BookDGV.Rows[selectedRowIndex].Cells[5].Value.ToString();

                if (BTitleTb.Text == "")
                {
                    key = 0;
                    stock = 0;
                }
                else
                {
                    key = Convert.ToInt32(BookDGV.Rows[selectedRowIndex].Cells[0].Value.ToString());
                    stock = Convert.ToInt32(BookDGV.Rows[selectedRowIndex].Cells[4].Value.ToString());
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            BTitleTb.Text = "";
            PriceTb.Text = "";
            QtyTb.Text = "";
            ClientNameTb.Text = "";
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {

            if (ClientNameTb.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into BillTbl Values('" + UserNameLbl.Text + "','" + ClientNameTb.Text + "'," + GrdTotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }


               

            }

        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        String prodname;


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID  PRODUCT  PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: Rs" + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("**********Book Store**********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void Bil_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }
    }
}
