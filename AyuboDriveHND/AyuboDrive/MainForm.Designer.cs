namespace AyuboDrive
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PkgBtn = new System.Windows.Forms.Button();
            this.VehicleBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LongTourBtn = new System.Windows.Forms.Button();
            this.DayTourBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RentBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.PkgBtn);
            this.groupBox1.Controls.Add(this.VehicleBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Explore";
            // 
            // PkgBtn
            // 
            this.PkgBtn.BackColor = System.Drawing.Color.Plum;
            this.PkgBtn.Location = new System.Drawing.Point(21, 111);
            this.PkgBtn.Name = "PkgBtn";
            this.PkgBtn.Size = new System.Drawing.Size(235, 46);
            this.PkgBtn.TabIndex = 1;
            this.PkgBtn.Text = "Packages";
            this.PkgBtn.UseVisualStyleBackColor = false;
            this.PkgBtn.Click += new System.EventHandler(this.PkgBtn_Click);
            // 
            // VehicleBtn
            // 
            this.VehicleBtn.BackColor = System.Drawing.Color.Plum;
            this.VehicleBtn.Location = new System.Drawing.Point(21, 47);
            this.VehicleBtn.Name = "VehicleBtn";
            this.VehicleBtn.Size = new System.Drawing.Size(235, 46);
            this.VehicleBtn.TabIndex = 0;
            this.VehicleBtn.Text = "Vehicles";
            this.VehicleBtn.UseVisualStyleBackColor = false;
            this.VehicleBtn.Click += new System.EventHandler(this.VehicleBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.LongTourBtn);
            this.groupBox2.Controls.Add(this.DayTourBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(360, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hire";
            // 
            // LongTourBtn
            // 
            this.LongTourBtn.BackColor = System.Drawing.Color.Plum;
            this.LongTourBtn.Location = new System.Drawing.Point(18, 111);
            this.LongTourBtn.Name = "LongTourBtn";
            this.LongTourBtn.Size = new System.Drawing.Size(235, 46);
            this.LongTourBtn.TabIndex = 5;
            this.LongTourBtn.Text = "Long Tour";
            this.LongTourBtn.UseVisualStyleBackColor = false;
            this.LongTourBtn.Click += new System.EventHandler(this.LongTourBtn_Click);
            // 
            // DayTourBtn
            // 
            this.DayTourBtn.BackColor = System.Drawing.Color.Plum;
            this.DayTourBtn.Location = new System.Drawing.Point(18, 47);
            this.DayTourBtn.Name = "DayTourBtn";
            this.DayTourBtn.Size = new System.Drawing.Size(235, 46);
            this.DayTourBtn.TabIndex = 4;
            this.DayTourBtn.Text = "Day Tour";
            this.DayTourBtn.UseVisualStyleBackColor = false;
            this.DayTourBtn.Click += new System.EventHandler(this.DayTourBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.RentBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(656, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 113);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rent";
            // 
            // RentBtn
            // 
            this.RentBtn.BackColor = System.Drawing.Color.Plum;
            this.RentBtn.Location = new System.Drawing.Point(21, 47);
            this.RentBtn.Name = "RentBtn";
            this.RentBtn.Size = new System.Drawing.Size(235, 46);
            this.RentBtn.TabIndex = 6;
            this.RentBtn.Text = "Rent";
            this.RentBtn.UseVisualStyleBackColor = false;
            this.RentBtn.Click += new System.EventHandler(this.RentBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(800, 407);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(133, 49);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(656, 407);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(133, 49);
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Ayubo Drive";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PkgBtn;
        private System.Windows.Forms.Button VehicleBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LongTourBtn;
        private System.Windows.Forms.Button DayTourBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RentBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}