using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASHION_STORE_MANAGEMENT_SYSTEM
{

    public partial class HomeUserControl : UserControl
    {

        private static HomeUserControl _instance;
        public static HomeUserControl Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new HomeUserControl();
                }
                return _instance;
            }
        }

        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
