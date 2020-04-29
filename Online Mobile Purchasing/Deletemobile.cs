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
    public partial class Deletemobile : Form
    {
        public Deletemobile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("MobileDelete_sp", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);

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
                MessageBox.Show("Deletion Complete");

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
