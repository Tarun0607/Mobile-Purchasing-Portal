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
    class connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True";
    }

    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connect obj=new connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                string insert="insert into Person values('"+textBox1.Text+"','"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox10.Text + "')";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = insert;
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                MessageBox.Show("Sign up Completed");
                this.Hide();
                Appbody obj1 = new Appbody();
                obj1.Show();



            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

        }
    }
}
