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
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database2.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private void getdata()
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string adu = "admin";
            da = new SqlDataAdapter("Select UserName FROM Person WHERE UserName like'" + textBox1.Text + "' and Password='" + textBox2.Text+"' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                label5.Hide();
                MessageBox.Show("Log in success");
                Appbody obj = new Appbody();
                this.Hide();
                obj.Show();

            }

            else if (name.Equals(adu) && pass.Equals(adu))
            {
                label5.Hide();
                MessageBox.Show("Successfully logged in as admin");
                admin obj = new admin();
                this.Hide();
                obj.Show();
            }
            else
            {
                label5.Show();
            }

            

        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            getdata();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup obj = new Signup();
            this.Hide();
            obj.Show();
        }
    }
}
