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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();                       
            string name , pwd;
            name = textBox1.Text;
            pwd = textBox2.Text;
            SqlCommand cmd = new SqlCommand("SELECT username,password FROM USER_DETAILS WHERE username='"+textBox1.Text+"'AND password='"+textBox2.Text+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {    //login successful
                
                MessageBox.Show("LOGIN SUCCESSFUL");
                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
                
            }
            else
            {
                //login failed
                MessageBox.Show("Invalid login!!! Please check username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 obj = new Form5();
            obj.Show();
        }
    }
}
