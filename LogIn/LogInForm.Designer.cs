namespace LogIn
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logInPanel = new Panel();
            forgotPassLinkLabel = new LinkLabel();
            loginButton = new Button();
            passwordPanel = new Panel();
            passwordIcon = new PictureBox();
            passwordTextBox = new TextBox();
            forgotPassLabel = new Label();
            passwordLabel = new Label();
            usernamePanel = new Panel();
            usernameIcon = new PictureBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            subtextLabel = new Label();
            label1H1 = new Label();
            logInPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            usernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            SuspendLayout();
            // 
            // logInPanel
            // 
            logInPanel.Controls.Add(forgotPassLinkLabel);
            logInPanel.Controls.Add(loginButton);
            logInPanel.Controls.Add(passwordPanel);
            logInPanel.Controls.Add(forgotPassLabel);
            logInPanel.Controls.Add(passwordLabel);
            logInPanel.Controls.Add(usernamePanel);
            logInPanel.Controls.Add(usernameLabel);
            logInPanel.Controls.Add(subtextLabel);
            logInPanel.Controls.Add(label1H1);
            logInPanel.Location = new Point(956, 70);
            logInPanel.Name = "logInPanel";
            logInPanel.Size = new Size(837, 698);
            logInPanel.TabIndex = 0;
            logInPanel.Paint += logInPanel_Paint;
            // 
            // forgotPassLinkLabel
            // 
            forgotPassLinkLabel.AutoSize = true;
            forgotPassLinkLabel.LinkColor = Color.FromArgb(0, 0, 192);
            forgotPassLinkLabel.Location = new Point(354, 554);
            forgotPassLinkLabel.Name = "forgotPassLinkLabel";
            forgotPassLinkLabel.Size = new Size(0, 20);
            forgotPassLinkLabel.TabIndex = 4;
            forgotPassLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Image = Properties.Resources.password_icon;
            loginButton.ImageAlign = ContentAlignment.MiddleLeft;
            loginButton.Location = new Point(285, 447);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(283, 70);
            loginButton.TabIndex = 1;
            loginButton.Text = "LOG IN";
            loginButton.TextAlign = ContentAlignment.MiddleRight;
            loginButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click_2;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.Transparent;
            passwordPanel.Controls.Add(passwordIcon);
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Location = new Point(52, 335);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(729, 45);
            passwordPanel.TabIndex = 2;
            passwordPanel.Paint += passwordPanel_Paint;
            // 
            // passwordIcon
            // 
            passwordIcon.BackgroundImage = Properties.Resources.password_icon;
            passwordIcon.BackgroundImageLayout = ImageLayout.Stretch;
            passwordIcon.Location = new Point(15, 3);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(41, 39);
            passwordIcon.TabIndex = 1;
            passwordIcon.TabStop = false;
            passwordIcon.Click += pictureBox1_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(75, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(651, 37);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // forgotPassLabel
            // 
            forgotPassLabel.AutoSize = true;
            forgotPassLabel.Cursor = Cursors.Hand;
            forgotPassLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPassLabel.ForeColor = SystemColors.HotTrack;
            forgotPassLabel.Location = new Point(348, 551);
            forgotPassLabel.Name = "forgotPassLabel";
            forgotPassLabel.Size = new Size(154, 23);
            forgotPassLabel.TabIndex = 1;
            forgotPassLabel.Text = "Forgot password?";
            forgotPassLabel.Click += passwordLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(52, 289);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(124, 31);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = Color.Transparent;
            usernamePanel.Controls.Add(usernameIcon);
            usernamePanel.Controls.Add(usernameTextBox);
            usernamePanel.Location = new Point(52, 210);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(729, 45);
            usernamePanel.TabIndex = 2;
            // 
            // usernameIcon
            // 
            usernameIcon.BackgroundImage = Properties.Resources.username_icon1;
            usernameIcon.BackgroundImageLayout = ImageLayout.Stretch;
            usernameIcon.Location = new Point(15, 3);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(41, 39);
            usernameIcon.TabIndex = 1;
            usernameIcon.TabStop = false;
            usernameIcon.Click += pictureBox1_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(75, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(651, 37);
            usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(52, 164);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(130, 31);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // subtextLabel
            // 
            subtextLabel.AutoSize = true;
            subtextLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtextLabel.Location = new Point(267, 92);
            subtextLabel.Name = "subtextLabel";
            subtextLabel.Size = new Size(321, 30);
            subtextLabel.TabIndex = 1;
            subtextLabel.Text = "Please login to you account";
            // 
            // label1H1
            // 
            label1H1.AutoSize = true;
            label1H1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1H1.Location = new Point(253, 45);
            label1H1.Name = "label1H1";
            label1H1.Size = new Size(348, 37);
            label1H1.TabIndex = 0;
            label1H1.Text = "Welcome to TrackWise!";
            label1H1.Click += label1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.log_in_page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1850, 858);
            Controls.Add(logInPanel);
            Name = "LogInForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            logInPanel.ResumeLayout(false);
            logInPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel logInPanel;
        private Label label1H1;
        private Label subtextLabel;
        private Panel usernamePanel;
        private TextBox usernameTextBox;
        private PictureBox usernameIcon;
        private Label usernameLabel;
        private Panel passwordPanel;
        private PictureBox passwordIcon;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button loginButton;
        private LinkLabel forgotPassLinkLabel;
        private Label forgotPassLabel;
    }
}
