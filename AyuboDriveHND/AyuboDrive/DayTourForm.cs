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
    public partial class DayTourForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-6neld53;Initial Catalog=AyuboDrive;Integrated Security=True");
        double ExHrCharge, ExKMCharge;

        public DayTourForm()
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
            MaxHrsText.Clear();
            MaxKmText.Clear();
            ExKmRateText.Clear();
            ExHrsRateText.Clear();
            NoHrsText.Clear();
            ExHrText.Clear();
            ExHrsChargeText.Clear();
            SKMReadText.Clear();
            EKMReadText.Clear();
            NoKMText.Clear();
            ExKMText.Clear();
            ExKMChargeText.Clear();
            TotCostText.Clear();
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
                MaxHrsText.Text = dr["Max_hrs"].ToString();
                ExKmRateText.Text = dr["Ex_km_rate"].ToString();
                ExHrsRateText.Text = dr["Ex_hr_rate"].ToString();
                PackRateText.Text = dr["P_rate"].ToString();

            }
            else
                MessageBox.Show("Package not found","Not Found", MessageBoxButtons.OK);
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillcomboBoxPack();
        }

        private void CalHrBtn_Click(object sender, EventArgs e)
        {
            DateTime STime, ETime;
            TimeSpan Ts;
            int Nhrs;
            STime = DateTime.Parse(dateTimePicker1.Text);
            ETime = DateTime.Parse(dateTimePicker2.Text);
            Ts = ETime - STime;
            Nhrs = Ts.Hours;
            NoHrsText.Text = Nhrs.ToString();

            int MaxHrs, ExtraHrs;
            MaxHrs = int.Parse(MaxHrsText.Text);
            if (MaxHrs < Nhrs)
            {
                ExtraHrs = Nhrs - MaxHrs;
            }
            else
            {
                ExtraHrs = 0;
            }
            ExHrText.Text = ExtraHrs.ToString();

            double ExHrsRate;
            ExHrsRate = double.Parse(ExHrsRateText.Text);
            ExHrCharge = ExtraHrs * ExHrsRate;
            ExHrsChargeText.Text = ExHrCharge.ToString();
        }

        private void CalKMBtn_Click(object sender, EventArgs e)
        {
            int SKM, EKM, Dif;
            //Dif=difference
            SKM = int.Parse(SKMReadText.Text);
            EKM = int.Parse(EKMReadText.Text);
            Dif = EKM - SKM;
            NoKMText.Text = Dif.ToString();

            int MaxKM, ExtraKM;
            MaxKM = int.Parse(MaxKmText.Text);
            if (MaxKM < Dif)
            {
                ExtraKM = Dif - MaxKM;
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

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f6 = new MainForm();
            f6.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TotCostBtn_Click(object sender, EventArgs e)
        {
            double PkgRate, TotCost;
            PkgRate = double.Parse(PackRateText.Text);
            TotCost = PkgRate + ExHrCharge + ExKMCharge;
            TotCostText.Text = TotCost.ToString();
        }
    }
}
