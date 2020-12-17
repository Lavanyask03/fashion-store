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
    public partial class AccessoriesUserControl : UserControl
    {
        private static AccessoriesUserControl _instance;
        public static AccessoriesUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccessoriesUserControl();
                }
                return _instance;
            }
        }
        public AccessoriesUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void AccessoriesUserControl_Load(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("@Pid","A01");
            cmd.Parameters.AddWithValue("@Price",700);
            String units = comboBox1.Text;
            int a = Convert.ToInt32(units);
            int final = a * 700;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A01");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox1.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "A02");
            cmd.Parameters.AddWithValue("@Price", 725);
            String units = comboBox3.Text;
            int a = Convert.ToInt32(units);
            int final = a * 725;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A02");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox3.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "A03");
            cmd.Parameters.AddWithValue("@Price", 600);
            String units = comboBox5.Text;
            int a = Convert.ToInt32(units);
            int final = a * 600;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size", "");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A03");
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
            cmd.Parameters.AddWithValue("@Pid", "A04");
            cmd.Parameters.AddWithValue("@Price", 21802);
            String units = comboBox7.Text;
            int a = Convert.ToInt32(units);
            int final = a * 21802;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered", a);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A04");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox7.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "A05");
            cmd.Parameters.AddWithValue("@Price", 11525);
            String units = comboBox2.Text;
            int a = Convert.ToInt32(units);
            int final = a * 11525;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A05");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox2.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "A06");
            cmd.Parameters.AddWithValue("@Price", 2000);
            String units = comboBox4.Text;
            int a = Convert.ToInt32(units);
            int final = a * 2000;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", "");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A06");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox4.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
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
            cmd.Parameters.AddWithValue("@Pid", "A07");
            cmd.Parameters.AddWithValue("@Price", 1699);
            String units = comboBox6.Text;
            int a = Convert.ToInt32(units);
            int final = a * 1699;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A07");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox6.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "A08");
            cmd.Parameters.AddWithValue("@Price", 3000);
            String units = comboBox8.Text;
            int a = Convert.ToInt32(units);
            int final = a * 3000;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", "");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A08");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox8.Text);
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
            cmd.Parameters.AddWithValue("@Pid", "A09");
            cmd.Parameters.AddWithValue("@Price", 2000);
            String units = comboBox9.Text;
            int a = Convert.ToInt32(units);
            int final = a * 2000;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size","");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A09");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox9.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("ADD_TO_CART", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", "A10");
            cmd.Parameters.AddWithValue("@Price", 500);
            String units = comboBox10.Text;
            int a = Convert.ToInt32(units);
            int final = a * 500;
            MessageBox.Show("The final Price is " + final);
            cmd.Parameters.AddWithValue("@Units_ordered",a);
            cmd.Parameters.AddWithValue("@Size", "");
            cmd.Parameters.AddWithValue("@final", final);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DECR_STOCK", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Pid", "A10");
            cmd1.Parameters.AddWithValue("@Units_ordered", comboBox10.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("PRODUCT ADDED TO CART");
            ((Form3)this.TopLevelControl).Close();
            Form4 obj = new Form4();
            obj.Show();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
