using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FASHION_STORE_MANAGEMENT_SYSTEM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
        const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        private string getUsername()
        {
            con.Open();
            string query = "select value from ADMIN where property ='username'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private string getPassword()
        {
            con.Open();
            string query = "select value from ADMIN where property ='password'";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = getUsername(), upass = getPassword(), name, pass;
            name = username.Text;
            pass = password.Text;

            if(name.Equals(uname)&& pass.Equals(upass))
            {
                MessageBox.Show("LOGIN SUCCESSFUL!!");
                this.Hide();
                Form6 obj = new Form6();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid login!!! Please check username and password");
            }
      
            
        }
    }
}
