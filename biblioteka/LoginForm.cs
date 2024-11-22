using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class LoginForm : Form
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "admin", "admin" },
            { "user", "user" }
        };

        public string CurrentRole { get; private set; } // Роль пользователя

        public LoginForm()
        {
            InitializeComponent();
            UpdateLocalization(); // Применить локализацию при запуске формы
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                MessageBox.Show(Localization.Translate("LoginSuccess"), Localization.Translate("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CurrentRole = username == "admin" ? "Admin" : "User";

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Localization.Translate("LoginError"), Localization.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLanguageToggle_Click(object sender, EventArgs e)
        {
            Localization.ToggleLanguage(); // Переключить язык
            UpdateLocalization(); // Обновить надписи
        }

        /// <summary>
        /// Обновляет надписи на текущий язык.
        /// </summary>
        private void UpdateLocalization()
        {
            this.Text = Localization.Translate("Login");
            lblUsername.Text = Localization.Translate("Username");
            lblPassword.Text = Localization.Translate("Password");
            btnLogin.Text = Localization.Translate("LoginButton");
            btnLanguageToggle.Text = Localization.CurrentLanguage == "ru" ? "EN" : "RU";
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
