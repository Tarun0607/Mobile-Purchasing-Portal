using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Mobile_Purchasing
{
    public partial class Personusercontrol : UserControl
    {
        private static Personusercontrol _instance;
        public static Personusercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Personusercontrol();
                }
                return _instance;
            }
        }


        public Personusercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Tarun\source\repos\Online Mobile Purchasing\Online Mobile Purchasing\Database2.mdf';Integrated Security=True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Showpersondata_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("         <<<INVALID SQL OPERATION>>>: \n" + ex);

                }

                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updateperson", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Person", textBox9.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@emailid", textBox2.Text);
            cmd.Parameters.AddWithValue("@gender", textBox3.Text);
            cmd.Parameters.AddWithValue("@Doorno", textBox4.Text);
            cmd.Parameters.AddWithValue("@Street", textBox5.Text);
            cmd.Parameters.AddWithValue("@City", textBox6.Text);
            cmd.Parameters.AddWithValue("@State", textBox7.Text);
            cmd.Parameters.AddWithValue("@Landmark", textBox8.Text);
            
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
            MessageBox.Show("Updation Complete");
            refresh_DataGridView();
        }

        private void Personusercontrol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchPerson_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Person", textBox9.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("         <<<INVALID SQL OPERATION>>>: \n" + ex);

                }

                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            refresh_DataGridView();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("removeperson", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Person", textBox9.Text);

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
                Form1 obj = new Form1();
                Appbody obj1 = new Appbody();
                obj1.Hide();
                obj.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

            
}
    }
