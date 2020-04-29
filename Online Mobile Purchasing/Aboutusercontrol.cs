using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Mobile_Purchasing
{
    public partial class Aboutusercontrol : UserControl
    {
        private static Aboutusercontrol _instance;
        public static Aboutusercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Aboutusercontrol();
                }
                return _instance;
            }
        }

        public Aboutusercontrol()
        {
            InitializeComponent();
        }
    }
}
