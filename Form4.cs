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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            string query = " insert into [PAYMENT] (username,name_on_card,card_no,cvv) values('" + this.username.Text + "','" + this.name_on_card.Text + "','" + this.card_no.Text + "','" + this.cvv.Text + "');";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("ORDER PLACED SUCCESSFULLY");
                while (dr.Read())
                {

                }
                con.Close();
                this.Hide();
                Form1 obj = new Form1();
                obj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
