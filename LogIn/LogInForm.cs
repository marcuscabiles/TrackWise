using System.Drawing;
using System.Drawing.Drawing2D;

namespace TrackWise
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

           

            logInPanel.BorderStyle = BorderStyle.None;
            usernamePanel.BorderStyle = BorderStyle.None;
            passwordPanel.BorderStyle = BorderStyle.None;

            logInPanel.BackColor = Color.White;
            usernamePanel.BackColor = Color.White;
            passwordPanel.BackColor = Color.White;

            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.PlaceholderText = "Enter your username";

            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.PlaceholderText = "Enter your password";
            passwordTextBox.PasswordChar = '*';

            this.Load -= Form1_Load;
            this.Load += Form1_Load;

            this.Resize -= Form1_Resize;
            this.Resize += Form1_Resize;

            logInPanel.Paint -= logInPanel_Paint;
            logInPanel.Paint += logInPanel_Paint;

            usernamePanel.Paint -= usernamePanel_Paint;
            usernamePanel.Paint += usernamePanel_Paint;

            passwordPanel.Paint -= passwordPanel_Paint;
            passwordPanel.Paint += passwordPanel_Paint;

            this.Shown += Form1_Shown;

            usernameTextBox.TabStop = false;
            passwordTextBox.TabStop = false;


            Image passwordIcon = Properties.Resources.password_icon; 

            loginButton.Size = new Size(283, 70);

            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 2;

            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.Black;

            loginButton.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);

            loginButton.Image = new Bitmap(passwordIcon, new Size(30, 30));
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;

            loginButton.Text = "   LOG IN";
            loginButton.TextAlign = ContentAlignment.MiddleLeft;
            loginButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            loginButton.Padding = new Padding(55, 0, 0, 0);
            loginButton.AutoSize = false;

            MakeButtonRounded(loginButton, 18);

            loginButton.Paint -= loginButton_Paint;
            loginButton.Paint += loginButton_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();

            MakePanelRounded(logInPanel, 30);
            MakePanelRounded(usernamePanel, 12);
            MakePanelRounded(passwordPanel, 12);

            logInPanel.Invalidate();
            usernamePanel.Invalidate();
            passwordPanel.Invalidate();

            MakeButtonRounded(loginButton, 18);
            loginButton.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();

            MakePanelRounded(logInPanel, 30);
            MakePanelRounded(usernamePanel, 12);
            MakePanelRounded(passwordPanel, 12);

            logInPanel.Invalidate();
            usernamePanel.Invalidate();
            passwordPanel.Invalidate();

            MakeButtonRounded(loginButton, 18);
            loginButton.Invalidate();
        }

        private void MakeButtonRounded(Button button, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                button.Region = new Region(path);
            }
        }

        private void loginButton_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int borderSize = 2;
            int radius = 18;

            Rectangle rect = new Rectangle(
                borderSize / 2,
                borderSize / 2,
                loginButton.Width - borderSize - 1,
                loginButton.Height - borderSize - 1
            );

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            using (Pen pen = new Pen(Color.Black, borderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = subtextLabel;
        }

        private void CenterLoginPanel()
        {
            int rightSideStart = this.ClientSize.Width / 2;
            int rightSideWidth = this.ClientSize.Width / 2;

            logInPanel.Left = rightSideStart + (rightSideWidth - logInPanel.Width) / 2;
            logInPanel.Top = (this.ClientSize.Height - logInPanel.Height) / 2;
        }

        private void logInPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(e, logInPanel, 30, Color.Black, 2);
        }

        private void usernamePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(e, usernamePanel, 12, Color.Black, 2);
        }

        private void passwordPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorder(e, passwordPanel, 12, Color.Black, 2);
        }

        private void MakePanelRounded(Panel panel, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                panel.Region = new Region(path);
            }
        }

        private void DrawRoundedBorder(PaintEventArgs e, Panel panel, int radius, Color borderColor, int borderSize)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                borderSize / 2,
                borderSize / 2,
                panel.Width - borderSize - 1,
                panel.Height - borderSize - 1
            );

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }

        private void loginButton_Click_2(object? sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }
    }
}