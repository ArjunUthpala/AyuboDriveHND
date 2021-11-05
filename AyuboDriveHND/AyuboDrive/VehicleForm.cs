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

namespace AyuboDrive
{
    public partial class VehicleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-6neld53;Initial Catalog=AyuboDrive;Integrated Security=True");
        public VehicleForm()
        {
            InitializeComponent();
        }
        private void FillPackComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select reg_no from Vehicles", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            VehicleComboBox.DataSource = dt;
            VehicleComboBox.DisplayMember = "reg_no";
            VehicleComboBox.ValueMember = "reg_no";
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //sqlst is an variable
            String sqlst;
            sqlst = "Select * from Vehicles where reg_no='" + VehicleComboBox.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                VTypeText.Text = dr["V_type"].ToString();
                ModelText.Text = dr["V_model"].ToString();
                DailyRateText.Text = dr["daily_rate"].ToString();
                WeeklyRateText.Text = dr["weekly_rate"].ToString();
                MonthlyRateText.Text = dr["monthly_rate"].ToString();
                DriverRateText.Text = dr["driver_rate"].ToString();
            }
            else
                MessageBox.Show("Vehicle not found", "Not Found", MessageBoxButtons.OK);
            con.Close();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            FillPackComboBox();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            VehicleComboBox.ResetText();
            VTypeText.Clear();
            ModelText.Clear();
            DailyRateText.Clear();
            WeeklyRateText.Clear();
            MonthlyRateText.Clear();
            DriverRateText.Clear();

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f6 = new MainForm();
            f6.Show();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            //sqlst is an variable
            String sqlst;
            sqlst = "insert into Vehicles(reg_no, V_type, V_model, daily_rate, weekly_rate, monthly_rate, driver_rate) " +
                "values('" + VehicleComboBox.Text + "','" + VTypeText.Text + "','" + ModelText.Text + "','" + DailyRateText.Text + "','" + WeeklyRateText.Text + "','" + MonthlyRateText.Text + "','" + DriverRateText.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vehicle Added", "Added", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string sqlst;
            sqlst = "Update Vehicles Set V_type='" + VTypeText.Text + "', V_model='" + ModelText.Text + "', daily_rate='" + DailyRateText.Text + "', weekly_rate='" + WeeklyRateText.Text + "', monthly_rate='" + MonthlyRateText.Text + "', driver_rate='" + DriverRateText.Text + "' Where reg_no='" + VehicleComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vehicle Updated", "Updated", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string sqlst;
            sqlst = "Delete from Vehicles Where reg_no='" + VehicleComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vehicle Deleted", "Deleted", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }
    }
}
