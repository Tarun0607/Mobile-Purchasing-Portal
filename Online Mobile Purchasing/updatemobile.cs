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
    public partial class updatemobile : Form
    {
        public updatemobile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("updatemobile", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
                cmd.Parameters.AddWithValue("@MobileName", textBox2.Text);
                cmd.Parameters.AddWithValue("@ScreenSize", textBox3.Text);
                cmd.Parameters.AddWithValue("@RAM", textBox4.Text);
                cmd.Parameters.AddWithValue("@Ratings", textBox5.Text);
                cmd.Parameters.AddWithValue("@SellerID", textBox6.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                    <<<INVALID SQL OPERATION>>> \n" + ex);
                }
                con.Close();
                MessageBox.Show("Updation complete");

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
