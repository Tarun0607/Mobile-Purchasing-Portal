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
    public partial class SettingsuserControl : UserControl
    {
        private static SettingsuserControl _instance;
        public static SettingsuserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SettingsuserControl();
                }
                return _instance;
            }
        }


        public SettingsuserControl()
        {
            InitializeComponent();
        }
    }
}
