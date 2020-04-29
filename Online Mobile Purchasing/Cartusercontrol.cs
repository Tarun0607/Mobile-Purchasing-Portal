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
    public partial class Cartusercontrol : UserControl
    {
        private static Cartusercontrol _instance;
        public static Cartusercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cartusercontrol();
                }
                return _instance;
            }
        }

        public Cartusercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void refresh_DataGridView()
        {


             try
            {
                SqlCommand cmd = new SqlCommand("ShowAllmobiledata_SP", con);
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

                dataGridcart.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

    private void Cartusercontrol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
            refresh_DataGridView1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Searchcart_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
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

                dataGridcart.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void refresh_DataGridView1()
        {


            try
            {
                SqlCommand cmd = new SqlCommand("InitialCart_sp", con);
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
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
























        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddtoCart_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
            
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
            refresh_DataGridView1();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Deletecart_sp", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductID", textBox2.Text);

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


                refresh_DataGridView1();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

