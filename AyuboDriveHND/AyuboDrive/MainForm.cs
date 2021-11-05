using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            VehicleForm f1 = new VehicleForm();
            f1.Show();
            this.Hide();
        }

        private void PkgBtn_Click(object sender, EventArgs e)
        {
            PackageForm f2 = new PackageForm();
            f2.Show();
            this.Hide();
        }

        private void DayTourBtn_Click(object sender, EventArgs e)
        {
            DayTourForm f3 = new DayTourForm();
            f3.Show();
            this.Hide();
        }

        private void LongTourBtn_Click(object sender, EventArgs e)
        {
            LongTourForm f4 = new LongTourForm();
            f4.Show();
            this.Hide();
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            RentForm f5 = new RentForm();
            f5.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm f7 = new LoginForm();
            f7.Show();
            this.Hide();
        }
    }
}
