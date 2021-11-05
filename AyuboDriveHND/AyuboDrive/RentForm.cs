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
    public partial class RentForm : Form
    {
        int DayCount, NumMonths, NumWeeks, NumDays;
        SqlConnection con = new SqlConnection("Data Source=desktop-6neld53;Initial Catalog=AyuboDrive;Integrated Security=True");
        public RentForm()
        {
            InitializeComponent();
        }
        private void FillRegComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select reg_no from Vehicles", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            RegComboBox.DataSource = dt;
            RegComboBox.DisplayMember = "reg_no";
            RegComboBox.ValueMember = "reg_no";
        }
        private void Clear()
        {
            RegComboBox.ResetText();
            TotDaysText.Clear();
            NumMonthsText.Clear();
            NumWeeksText.Clear();
            NumDaysText.Clear();
            VTypeText.Clear();
            VModelText.Clear();
            DailyRateText.Clear();
            WeeklyRateText.Clear();
            MonthlyRateText.Clear();
            DriverRateText.Clear();
            TotCostText.Clear();
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

        private void TotCostBtn_Click(object sender, EventArgs e)
        {
            double DayRate, WeekRate, MonthRate, DriverRate, TotCost;
            DayRate = double.Parse(DailyRateText.Text);
            WeekRate = double.Parse(WeeklyRateText.Text);
            MonthRate = double.Parse(MonthlyRateText.Text);
            DriverRate = double.Parse(DriverRateText.Text);

            if (DriverCheck.Checked == true)
                TotCost = (MonthRate * NumMonths + WeekRate * NumWeeks + DayRate * NumDays + DayCount * DriverRate);
            else
                TotCost = (MonthRate * NumMonths + WeekRate * NumWeeks + DayRate * NumDays);
            TotCostText.Text = TotCost.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //sqlst is an variable
            String sqlst;
            sqlst = "Select * from Vehicles where reg_no='" + RegComboBox.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                VTypeText.Text = dr["V_type"].ToString();
                VModelText.Text = dr["V_model"].ToString();
                DailyRateText.Text = dr["daily_rate"].ToString();
                WeeklyRateText.Text = dr["weekly_rate"].ToString();
                MonthlyRateText.Text = dr["monthly_rate"].ToString();
                DriverRateText.Text = dr["driver_rate"].ToString();
            }
            else
                MessageBox.Show("Vehicle not found", "Not Found", MessageBoxButtons.OK);
            con.Close();
        }

        private void CalDateBtn_Click(object sender, EventArgs e)
        {
            DateTime Rented_Date, Returned_Date;
            Rented_Date = DateTime.Parse(RentDatePick.Text);
            Returned_Date = DateTime.Parse(ReturnDatePick.Text);
            TimeSpan ts;
            ts = Returned_Date - Rented_Date;
            double totdays;
            totdays = ts.Days;
            TotDaysText.Text = totdays.ToString();

            DayCount = int.Parse(TotDaysText.Text);

            //months calculation
            NumMonths = DayCount / 30;
            NumMonthsText.Text = NumMonths.ToString();

            //weeks calculation
            int Remainder;
            Remainder = DayCount % 30;
            NumWeeks = Remainder / 7;
            NumWeeksText.Text = NumWeeks.ToString();

            //days calculation
            NumDays = Remainder % 7;
            NumDaysText.Text = NumDays.ToString();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            FillRegComboBox();
        }
    }
}
