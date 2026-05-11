namespace LogIn
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
            sidePanel = new Panel();
            logoutButton = new Button();
            reportsButton = new Button();
            attendanceButton = new Button();
            employeesButton = new Button();
            dashboardButton = new Button();
            trackwiseIconPictureBox = new PictureBox();
            contentPanel = new Panel();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackwiseIconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(10, 54, 105);
            sidePanel.Controls.Add(logoutButton);
            sidePanel.Controls.Add(reportsButton);
            sidePanel.Controls.Add(attendanceButton);
            sidePanel.Controls.Add(employeesButton);
            sidePanel.Controls.Add(dashboardButton);
            sidePanel.Controls.Add(trackwiseIconPictureBox);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(261, 858);
            sidePanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.Image = Properties.Resources.logout_icon;
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 772);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(261, 86);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Log Out";
            logoutButton.TextAlign = ContentAlignment.MiddleRight;
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            reportsButton.FlatStyle = FlatStyle.Flat;
            reportsButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportsButton.Image = Properties.Resources.reports_icon;
            reportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportsButton.Location = new Point(0, 491);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(261, 86);
            reportsButton.TabIndex = 4;
            reportsButton.Text = "Reports";
            reportsButton.TextAlign = ContentAlignment.MiddleRight;
            reportsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportsButton.UseVisualStyleBackColor = true;
            // 
            // attendanceButton
            // 
            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceButton.Image = Properties.Resources.attendance_icon;
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceButton.Location = new Point(0, 399);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(261, 86);
            attendanceButton.TabIndex = 3;
            attendanceButton.Text = "Attendance";
            attendanceButton.TextAlign = ContentAlignment.MiddleRight;
            attendanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            attendanceButton.UseVisualStyleBackColor = true;
            // 
            // employeesButton
            // 
            employeesButton.FlatStyle = FlatStyle.Flat;
            employeesButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesButton.Image = Properties.Resources.employees_icon;
            employeesButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeesButton.Location = new Point(0, 307);
            employeesButton.Name = "employeesButton";
            employeesButton.Size = new Size(261, 86);
            employeesButton.TabIndex = 2;
            employeesButton.Text = "Employees";
            employeesButton.TextAlign = ContentAlignment.MiddleRight;
            employeesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            employeesButton.UseVisualStyleBackColor = true;
            employeesButton.Click += employeesButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(10, 54, 105);
            dashboardButton.BackgroundImageLayout = ImageLayout.Zoom;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.Image = Properties.Resources.dashboard_icon1;
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(0, 215);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(261, 86);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleRight;
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += button1_Click;
            // 
            // trackwiseIconPictureBox
            // 
            trackwiseIconPictureBox.BackgroundImage = Properties.Resources.trackwise_logo;
            trackwiseIconPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            trackwiseIconPictureBox.Location = new Point(0, 33);
            trackwiseIconPictureBox.Name = "trackwiseIconPictureBox";
            trackwiseIconPictureBox.Size = new Size(261, 139);
            trackwiseIconPictureBox.TabIndex = 1;
            trackwiseIconPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(261, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1589, 858);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1850, 858);
            Controls.Add(contentPanel);
            Controls.Add(sidePanel);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackwiseIconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private PictureBox trackwiseIconPictureBox;
        private Button dashboardButton;
        private Button employeesButton;
        private Button attendanceButton;
        private Button reportsButton;
        private Button logoutButton;
        private Panel contentPanel;
    }
}