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

namespace FASHION_STORE_MANAGEMENT_SYSTEM
{
    public partial class FeedbackUserControl : UserControl
    {
        private static FeedbackUserControl _instance;
        public static FeedbackUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FeedbackUserControl();
                }
                return _instance;
            }
        }
        public FeedbackUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            string query = " insert into [FEEDBACK] (username,Pid,Feedback) values('" + this.username.Text + "','" + this.Pid.Text + "','" + this.Feedback.Text + "');";
           //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\FASHION_STORE_MANAGEMENT_SYSTEM\FASHION_STORE_MANAGEMENT_SYSTEM\Database.mdf;Integrated Security=True


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Feedback Submitted");
                while (dr.Read())
                {

                }
     
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
