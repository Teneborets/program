using System;
using System.Windows.Forms;
using TENEBORETS.Data;

namespace TENEBORETS
{
    public partial class AdminLoginForm : Form
    {
        private readonly RegistrationRepository _repository = RegistrationRepository.Instance;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = txtPassword.Text;

            if (_repository.ValidateAdmin(login, password))
            {
                lblError.Text = string.Empty;
                Hide();

                using (var dashboard = new AdminDashboardForm())
                {
                    dashboard.ShowDialog(this);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                lblError.Text = "Неверный логин или пароль.";
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

