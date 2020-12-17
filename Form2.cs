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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            const string ConnectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            string query1 = "SELECT username FROM USER_DETAILS WHERE username='"+username.Text+ "'";
            string query = " insert into [USER_DETAILS] (username,password,fullname,email,address,phone) values('" + this.username.Text + "','" + this.password.Text + "','" + this.fullname.Text + "','" + this.email.Text + "','" + this.address.Text + "','" + this.phone.Text + "');";
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\FASHION_STORE_MANAGEMENT_SYSTEM\FASHION_STORE_MANAGEMENT_SYSTEM\Database.mdf;Integrated Security=True

           
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                try
                {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                        dr = cmd1.ExecuteReader();
                        MessageBox.Show("successfully registered");
                        while (dr.Read())
                        {

                        }
                        this.Hide();
                        Form1 obj = new Form1();
                        obj.Show();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                 }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
            
    }
}
