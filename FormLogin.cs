using SIKOPI_DOPY_MVC_GREENBEAN.Controllers;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;
using SIKOPI_DOPY_MVC_GREENBEAN.Views;

namespace SIKOPI_DOPY_MVC_GREENBEAN
{
    public partial class FormLogin : Form
    {
        private readonly AuthController _authController;

        public FormLogin()
        {
            InitializeComponent();

            _authController = new AuthController();

            txtPassword.UseSystemPasswordChar = true;

            btnLogin.Click -= btnLogin_Click;
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                User user = _authController.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (user.Role == "admin")
                {
                    FormUtamaAdmin form = new FormUtamaAdmin();
                    form.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Untuk tahap ini baru role admin yang dibuat.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
