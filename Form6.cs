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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //String syntax = "select Id,log from Trans_log";
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select_trigger", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL EXCEPTION OCCURED!!!" + ex);
            }
            
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Refresh_datagridview();
        }
        const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\FASHION_STORE_MANAGEMENT_SYSTEM1\\FASHION_STORE_MANAGEMENT_SYSTEM\\Database.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);

        public void Refresh_datagridview()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SHOW_STOCK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SQL EXCEPTION OCCURED!!!" + ex);
                }
                con.Close();
                Stockdgv.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("EXCEPTION OCCURED!!!"+ex);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE_STOCK",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", Pid.Text);
            cmd.Parameters.AddWithValue("@Stock", Stock.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("SQL EXCEPTION OCCURED"+ex);
            }
            con.Close();
            Refresh_datagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
