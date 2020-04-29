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
    public partial class Transactionusercontrol : UserControl
    {
        private static Transactionusercontrol _instance;
        public static Transactionusercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactionusercontrol();
                }
                return _instance;
            }
        }

        public Transactionusercontrol()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True");



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








private void Transactionusercontrol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView1();  
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            refresh_DataGridView1();

        }

        

        public void refresh_DataGridView2()
        {


            try
            {
                SqlCommand cmd = new SqlCommand("Initialtransaction_sp", con);
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

                dataGridView2.DataSource = DS.Tables[0];
                dataGridView2.AllowUserToAddRows = false;

                int sum = 0;
                for(int i = 0; i <= dataGridView2.Rows.Count-1; i++)
                {
                    sum = sum +int.Parse (dataGridView2.Rows[i].Cells[4].Value.ToString());
                }
                textBox1.Text = sum.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }



  private void button1_Click(object sender, EventArgs e)
        {
            refresh_DataGridView2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Successfull!!\nProduct will be delivered within next 15 working days");
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Cancelled");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
