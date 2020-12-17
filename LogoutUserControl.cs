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
    public partial class LogoutUserControl : UserControl
    {
        private static LogoutUserControl _instance;
        public static LogoutUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogoutUserControl();
                }
                return _instance;
            }
        }
        public LogoutUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" LOGOUT SUCCESSFUL!!! ");
            ((Form3)this.TopLevelControl).Close();
            Form1 obj = new Form1();
            obj.Show();
            
        }
    }
}
