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
    public partial class MenUserControl : UserControl
    {
        private static MenUserControl _instance;
        public static MenUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MenUserControl();
                }
                return _instance;
            }
        }
        public MenUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("@Pid", "M05");
            cmd.Parameters.AddWithValue("@Price", 1300);
            String units = comboBox1.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1300;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size",comboBox2.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "M05");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox1.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "M01");
            cmd.Parameters.AddWithValue("@Price", 1118);
            String units = comboBox3.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1118;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", comboBox4.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "M01");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox3.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "M02");
            cmd.Parameters.AddWithValue("@Price", 1500);
            String units = comboBox5.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1500;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", comboBox6.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "M02");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox5.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "M03");
            cmd.Parameters.AddWithValue("@Price", 800);
            String units = comboBox7.Text;
            int a = Convert.ToInt32(units);
            int final = a * 800;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", comboBox8.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "M03");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox7.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "M04");
            cmd.Parameters.AddWithValue("@Price", 1200);
            String units = comboBox9.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1200;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", comboBox10.Text);
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "M04");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox9.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MenUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
