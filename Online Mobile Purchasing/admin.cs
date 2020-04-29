using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Mobile_Purchasing
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmobile obj = new Addmobile();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deletemobile obj = new Deletemobile();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatemobile obj = new updatemobile();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addsellers obj = new Addsellers();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete_Sellers obj = new Delete_Sellers();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updatesellers obj = new updatesellers();
            obj.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Delete_Sellers obj = new Delete_Sellers();
            obj.Show();
        }
    }
}
