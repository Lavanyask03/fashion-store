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
    public partial class TrendsUserControl : UserControl
    {
        private static TrendsUserControl _instance;
        public static TrendsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TrendsUserControl();
                }
                return _instance;
            }
        }
        public TrendsUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
