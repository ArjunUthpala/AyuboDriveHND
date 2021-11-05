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
    public partial class PackageForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-6neld53;Initial Catalog=AyuboDrive;Integrated Security=True");
        public PackageForm()
        {
            InitializeComponent();
            
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            FillPackComboBox();
        }

        private void FillPackComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select P_ID from Package", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PackComboBox.DataSource = dt;
            PackComboBox.DisplayMember = "P_ID";
            PackComboBox.ValueMember = "P_ID";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            //sqlst is an variable
            String sqlst;
            sqlst = "Select * from Package where P_ID='" + PackComboBox.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PackNameText.Text = dr["P_Name"].ToString();
                VTypeText.Text = dr["V_Type"].ToString();
                MaxKmText.Text = dr["Max_km"].ToString();
                MaxHrsText.Text = dr["Max_hrs"].ToString();
                ExKmRateText.Text = dr["Ex_km_rate"].ToString();
                ExHrsRateText.Text = dr["Ex_hr_rate"].ToString();
                PackRateText.Text = dr["P_rate"].ToString();
                VNightParkText.Text = dr["V_night_rate"].ToString();
                DNightParkText.Text = dr["D_night_rate"].ToString();

            }
            else
                MessageBox.Show("Package not found","Not Found", MessageBoxButtons.OK);
            con.Close();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            //sqlst is an variable
            String sqlst;
            sqlst = "insert into Package(P_ID, P_Name, V_Type, Max_km, Max_hrs, Ex_km_rate, Ex_hr_rate, P_Rate, V_night_rate, D_night_rate) " +
                "values('" + PackComboBox.Text + "','" + PackNameText.Text + "','" + VTypeText.Text + "','" + MaxKmText.Text + "','" + MaxHrsText.Text + "','" + ExKmRateText.Text + "','" + ExHrsRateText.Text + "','" + PackRateText.Text + "','" + VNightParkText.Text + "','" + DNightParkText.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Package Added", "Added", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }

        private void Clear()
        {
            PackComboBox.ResetText();
            PackNameText.Clear();
            VTypeText.Clear();
            MaxKmText.Clear();
            MaxHrsText.Clear();
            ExKmRateText.Clear();
            ExHrsRateText.Clear();
            PackRateText.Clear();
            VNightParkText.Clear();
            DNightParkText.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f6 = new MainForm();
            f6.Show();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string sqlst;
            sqlst = "Update Package Set P_Name= '" + PackNameText.Text + "', V_Type='" + VTypeText.Text + "', Max_km='" + MaxKmText.Text + "', Max_hrs='" + MaxHrsText.Text + "', Ex_km_rate='" + ExKmRateText.Text + "', Ex_hr_rate='" + ExHrsRateText.Text + "', P_Rate='" + PackRateText.Text + "', V_night_rate='" + VNightParkText.Text + "', D_night_rate='" + DNightParkText.Text + "' Where P_ID='" + PackComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Package Updated", "Updated", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string sqlst;
            sqlst = "Delete from Package Where P_ID='" + PackComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Package Deleted", "Deleted", MessageBoxButtons.OK);
            con.Close();
            Clear();
        }
    }
}
