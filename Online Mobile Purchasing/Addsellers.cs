using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Mobile_Purchasing
{
    public partial class Addsellers : Form
    {
        public Addsellers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Addseller", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SellerID", textBox1.Text);
            cmd.Parameters.AddWithValue("@SellerName", textBox2.Text);
            cmd.Parameters.AddWithValue("@ShopName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Street", textBox4.Text);
            cmd.Parameters.AddWithValue("@City", textBox5.Text);
            cmd.Parameters.AddWithValue("@State", textBox6.Text);
            cmd.Parameters.AddWithValue("@sellerratings", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("             <<<INVALID SQL OPERATION>>> \n" + ex);
            }
            con.Close();
            MessageBox.Show("Insertion complete");

        }
    }
}
