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
    public partial class WomenUserControl : UserControl
    {
        private static WomenUserControl _instance;
        public static WomenUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WomenUserControl();
                }
                return _instance;
            }
        }
        public WomenUserControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WomenUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "W02");
            cmd.Parameters.AddWithValue("@Price", 1000);
            String units = comboBox3.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1000;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", comboBox4.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "W02");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox3.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "W03");
            cmd.Parameters.AddWithValue("@Price", 500);
            String units = comboBox5.Text;
            int a = Convert.ToInt32(units);
            int final = a * 500;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", comboBox6.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "W03");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox5.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "W05");
            cmd.Parameters.AddWithValue("@Price", 1330);
            String units = comboBox9.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1330;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", comboBox10.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "W05");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox9.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "W04");
            cmd.Parameters.AddWithValue("@Price", 900);
            String units = comboBox7.Text;
            int a = Convert.ToInt32(units);
            int final = a * 900;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", comboBox8.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "W04");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox7.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "W01");
            cmd.Parameters.AddWithValue("@Price", 1600);
            String units = comboBox1.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1600;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", comboBox2.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "W01");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox1.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
