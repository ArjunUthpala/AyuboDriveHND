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
    public partial class LongTourForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-6neld53;Initial Catalog=AyuboDrive;Integrated Security=True");
        double DOCharge; //Driver overnight charge
        double VOCharge; //vehicle overnight charge
        double ExKMCharge, totdays; 
        public LongTourForm()
        {
            InitializeComponent();
        }
        private void FillcomboBoxPack()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select P_ID from Package", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxPack.DataSource = dt;
            comboBoxPack.DisplayMember = "P_ID";
            comboBoxPack.ValueMember = "P_ID";
        }
        private void Clear()
        {
            comboBoxPack.ResetText();
            PackNameText.Clear();
            PackRateText.Clear();
            MaxKmText.Clear();
            ExKmRateText.Clear();
            DORText.Clear();
            VORText.Clear();
            NumDaysText.Clear();
            NumNightsText.Clear();
            SKMReadText.Clear();
            EKMReadText.Clear();
            NumKMText.Clear();
            DOChargeText.Clear();
            VOChargeText.Clear();
            ExKMText.Clear();
            ExKMChargeText.Clear();
            TotCostText.Clear();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f6 = new MainForm();
            f6.Show();
        }

        private void LongTourForm_Load(object sender, EventArgs e)
        {
            FillcomboBoxPack();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //sqlst is an variable
            String sqlst;
            sqlst = "Select * from Package where P_ID='" + comboBoxPack.Text + "'";

            SqlCommand cmd = new SqlCommand(sqlst, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PackNameText.Text = dr["P_Name"].ToString();
                MaxKmText.Text = dr["Max_km"].ToString();
                DORText.Text = dr["D_night_rate"].ToString();
                ExKmRateText.Text = dr["Ex_km_rate"].ToString();
                VORText.Text = dr["V_night_rate"].ToString();
                PackRateText.Text = dr["P_rate"].ToString();
            }
            else
                MessageBox.Show("Package not found", "Not Found", MessageBoxButtons.OK);
            con.Close();
        }

        private void CalDayBtn_Click(object sender, EventArgs e)
        {
            DateTime Start_Date, End_Date;
            Start_Date = DateTime.Parse(StartDatePicker.Text);
            End_Date = DateTime.Parse(EndDatePicker.Text);
            TimeSpan ts;
            ts = End_Date - Start_Date;
            double totnights;
            totdays = ts.Days;
            NumDaysText.Text = totdays.ToString();
            totnights = totdays - 1;
            NumNightsText.Text = totnights.ToString();

            //driver overnight charge calculation
            double DOChargeRate;
            DOChargeRate = double.Parse(DORText.Text);
            DOCharge = DOChargeRate * totnights;
            DOChargeText.Text = DOCharge.ToString();

            //vehicle overnight charge calculation
            double VOChargeRate;
            VOChargeRate = double.Parse(VORText.Text);
            VOCharge = VOChargeRate * totnights;
            VOChargeText.Text = VOCharge.ToString();
        }

        private void TotCostBtn_Click(object sender, EventArgs e)
        {
            double PkgRate, TotCost, BaseHireCharge;
            PkgRate = double.Parse(PackRateText.Text);
            BaseHireCharge = PkgRate * totdays;
            BaseHireChargeText.Text = BaseHireCharge.ToString();
            TotCost = BaseHireCharge + DOCharge + VOCharge + ExKMCharge;
            TotCostText.Text = TotCost.ToString();
        }

        private void CalKMBtn_Click(object sender, EventArgs e)
        {
            int SKM, EKM, Dif;
            //Dif=difference
            SKM = int.Parse(SKMReadText.Text);
            EKM = int.Parse(EKMReadText.Text);
            Dif = EKM - SKM;
            NumKMText.Text = Dif.ToString();

            double MaxKM, MaxKMJourney, ExtraKM;
            MaxKM = double.Parse(MaxKmText.Text);
            MaxKMJourney = MaxKM * totdays;
            if (MaxKMJourney < Dif)
            {
                ExtraKM = Dif - MaxKMJourney;
            }
            else
            {
                ExtraKM = 0;
            }
            ExKMText.Text = ExtraKM.ToString();



            double ExKMRate;
            ExKMRate = double.Parse(ExKmRateText.Text);
            ExKMCharge = ExtraKM * ExKMRate;
            ExKMChargeText.Text = ExKMCharge.ToString();
        }
    }
}
