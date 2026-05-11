using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackWise
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Image icon = Properties.Resources.dashboard_icon1;

            dashboardButton.Size = new Size(261, 86);

            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.FlatAppearance.BorderSize = 0;

            dashboardButton.BackColor = Color.FromArgb(10, 54, 105);
            dashboardButton.ForeColor = Color.White;

            dashboardButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            dashboardButton.Image = new Bitmap(icon, new Size(30, 30));
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;

            dashboardButton.Text = "   Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            dashboardButton.Padding = new Padding(25, 0, 0, 0);


            Image employeesIcon = Properties.Resources.employees_icon; 

            employeesButton.Size = new Size(261, 86);

            employeesButton.FlatStyle = FlatStyle.Flat;
            employeesButton.FlatAppearance.BorderSize = 0;

            employeesButton.BackColor = Color.FromArgb(10, 54, 105);
            employeesButton.ForeColor = Color.White;

            employeesButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            employeesButton.Image = new Bitmap(employeesIcon, new Size(30, 30));
            employeesButton.ImageAlign = ContentAlignment.MiddleLeft;

            employeesButton.Text = "   Employees";
            employeesButton.TextAlign = ContentAlignment.MiddleLeft;
            employeesButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            employeesButton.Padding = new Padding(25, 0, 0, 0);

            employeesButton.AutoSize = false;


            Image attendanceIcon = Properties.Resources.attendance_icon; 

            attendanceButton.Size = new Size(261, 86);

            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.FlatAppearance.BorderSize = 0;

            attendanceButton.BackColor = Color.FromArgb(10, 54, 105);
            attendanceButton.ForeColor = Color.White;

            attendanceButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            attendanceButton.Image = new Bitmap(attendanceIcon, new Size(30, 30));
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;

            attendanceButton.Text = "   Attendance";
            attendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            attendanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            attendanceButton.Padding = new Padding(25, 0, 0, 0);

            attendanceButton.AutoSize = false;


            Image reportsIcon = Properties.Resources.reports_icon; 

            reportsButton.Size = new Size(261, 86);

            reportsButton.FlatStyle = FlatStyle.Flat;
            reportsButton.FlatAppearance.BorderSize = 0;

            reportsButton.BackColor = Color.FromArgb(10, 54, 105);
            reportsButton.ForeColor = Color.White;

            reportsButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            reportsButton.Image = new Bitmap(reportsIcon, new Size(30, 30));
            reportsButton.ImageAlign = ContentAlignment.MiddleLeft;

            reportsButton.Text = "   Reports";
            reportsButton.TextAlign = ContentAlignment.MiddleLeft;
            reportsButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            reportsButton.Padding = new Padding(25, 0, 0, 0);

            reportsButton.AutoSize = false;


            Image logoutIcon = Properties.Resources.logout_icon; 

            logoutButton.Size = new Size(261, 86);

            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.FlatAppearance.BorderSize = 0;

            logoutButton.BackColor = Color.FromArgb(10, 54, 105);
            logoutButton.ForeColor = Color.White;

            logoutButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            logoutButton.Image = new Bitmap(logoutIcon, new Size(30, 30));
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;

            logoutButton.Text = "   Log Out";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            logoutButton.Padding = new Padding(25, 0, 0, 0);

            logoutButton.AutoSize = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object? sender, EventArgs e)
        {

        }

        private void employeesButton_Click(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
