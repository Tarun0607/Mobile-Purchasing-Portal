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
    public partial class Addmobile : Form
    {
        public Addmobile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Mobileadd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
            cmd.Parameters.AddWithValue("@MobileID", textBox2.Text);
            cmd.Parameters.AddWithValue("@MobileName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Manufacturer", textBox4.Text);
            cmd.Parameters.AddWithValue("@OStype", textBox5.Text);
            cmd.Parameters.AddWithValue("@ScreenSize", textBox6.Text);
            cmd.Parameters.AddWithValue("@Colour", textBox7.Text);
            cmd.Parameters.AddWithValue("@RAM", textBox8.Text);
            cmd.Parameters.AddWithValue("@Storage", textBox9.Text);
            cmd.Parameters.AddWithValue("@Battery", textBox10.Text);
            cmd.Parameters.AddWithValue("@FrontCamera", textBox11.Text);
            cmd.Parameters.AddWithValue("@RearCamera", textBox12.Text);
            cmd.Parameters.AddWithValue("@Price", textBox13.Text);
            cmd.Parameters.AddWithValue("@Ratings", textBox14.Text);
            cmd.Parameters.AddWithValue("@SellerID", textBox15.Text);
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
