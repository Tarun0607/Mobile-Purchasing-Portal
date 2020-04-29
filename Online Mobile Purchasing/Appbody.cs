using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Online_Mobile_Purchasing
{
    public partial class Appbody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Appbody()
        {
            InitializeComponent();
            //Initialization for sliding panel
            IsSlidingPanelExpanded = true;
            expandSlidingpanelGUI();
        }

        private void Appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();
        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffbutton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
  
            obj.Show();
            MessageBox.Show("Logged out Successful");
        }

        private void Titlebarpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void expandSlidingpanelGUI()
        {
            //GUI Adjustment for expanding
            MobilesTabbutton.Text = "MOBILES";
            PersonTabbutton.Text = "PROFILE";
            Carttabbutton.Text = "CART";
            Transactiontabbutton.Text = "TRANSACTIONS";
            Settingstabbutton.Text = "SETTINGS";
            Abouttabbutton.Text = "ABOUT";
            SlidingPanel_Togglebutton.Image = Properties.Resources.icons8_back_26;
            MobilesTabbutton.Image = null;
            PersonTabbutton.Image = null ;
            Carttabbutton.Image = null;
            Transactiontabbutton.Image = null;
            Settingstabbutton.Image = null;
            Abouttabbutton.Image= null;
        }
        public void retractSlidingpanelGUI()
        {
            //GUI Adjustment for retracting
            MobilesTabbutton.Text = "";
            PersonTabbutton.Text = "";
            Carttabbutton.Text = "";
            Transactiontabbutton.Text = "";
            Settingstabbutton.Text = "";
            Abouttabbutton.Text = "";
            SlidingPanel_Togglebutton.Image = Properties.Resources.icons8_forward_24;
            MobilesTabbutton.Image = Properties.Resources.icons8_mobile_26;
            PersonTabbutton.Image = Properties.Resources.icons8_user_24;
            Carttabbutton.Image = Properties.Resources.icons8_add_shopping_cart_32;
            Transactiontabbutton.Image = Properties.Resources.icons8_transaction_32;
            Settingstabbutton.Image = Properties.Resources.icons8_automatic_26;
            Abouttabbutton.Image = Properties.Resources.iconfinder_about_71696;
        }

        //Sliding Panel code starts from here
        bool IsSlidingPanelExpanded;
        const int Maxsliderwidth=193;
        const int Minsliderwidth=72;

        private void SlidingPanel_Togglebutton_Click(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                retractSlidingpanelGUI();
            }
            SlidingPaneltimer.Start();
        }

        private void SlidingPaneltimer_Tick(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                //retract panel
                Slidingpanel.Width -= 30;
                if (Slidingpanel.Width <= Minsliderwidth)
                {
                    //stop retract
                    IsSlidingPanelExpanded = false;
                    SlidingPaneltimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                Slidingpanel.Width += 30;
                if (Slidingpanel.Width >= Maxsliderwidth)
                {
                    //stop expanding
         
                    IsSlidingPanelExpanded = true;
                    SlidingPaneltimer.Stop();
                    expandSlidingpanelGUI();

                    this.Refresh();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(SettingsuserControl.Instance))
            {
                ContentPanel.Controls.Add(SettingsuserControl.Instance);
                SettingsuserControl.Instance.Dock = DockStyle.Fill;
                SettingsuserControl.Instance.BringToFront();
            }
            else
            {
                SettingsuserControl.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Personusercontrol.Instance))
            {
                ContentPanel.Controls.Add(Personusercontrol.Instance);
                Personusercontrol.Instance.Dock = DockStyle.Fill;
                Personusercontrol.Instance.BringToFront();
            }
            else
            {
                Personusercontrol.Instance.BringToFront();
            }
        }

        private void MobilesTabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Mobileusercontrol.Instance))
            {
                ContentPanel.Controls.Add(Mobileusercontrol.Instance);
                Mobileusercontrol.Instance.Dock = DockStyle.Fill;
                Mobileusercontrol.Instance.BringToFront();
            }
            else
            {
                Mobileusercontrol.Instance.BringToFront();
            }
        }

        private void Carttabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Cartusercontrol.Instance))
            {
                ContentPanel.Controls.Add(Cartusercontrol.Instance);
                Cartusercontrol.Instance.Dock = DockStyle.Fill;
                Cartusercontrol.Instance.BringToFront();
            }
            else
            {
                Cartusercontrol.Instance.BringToFront();
            }
        }

        private void Transactiontabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transactionusercontrol.Instance))
            {
                ContentPanel.Controls.Add(Transactionusercontrol.Instance);
                Transactionusercontrol.Instance.Dock = DockStyle.Fill;
                Transactionusercontrol.Instance.BringToFront();
            }
            else
            {
                Transactionusercontrol.Instance.BringToFront();
            }
        }

        private void Abouttabbutton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Aboutusercontrol.Instance))
            {
                ContentPanel.Controls.Add(Aboutusercontrol.Instance);
                Aboutusercontrol.Instance.Dock = DockStyle.Fill;
                Aboutusercontrol.Instance.BringToFront();
            }
            else
            {
               Aboutusercontrol.Instance.BringToFront();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
