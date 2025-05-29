using Login.Data;
using Login.Views;

namespace Login
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioData data = new UsuarioData();

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool ValidarTxt()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtUser.Text)) return false;
            if (string.IsNullOrEmpty(txtPassword.Text)) return false;
            return valid;
            
        }

        private void LimpiarTxt()
        {
            txtPassword.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string clave = txtPassword.Text;

            if (!ValidarTxt())
            {
                MessageBox.Show("Ingrese su usuario y clave", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTxt();
                return;
            }

            if (data.ValidarUsuario(usuario, clave))
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Show();
                LimpiarTxt();
                return;
            }
            else 
            {
                MessageBox.Show("El usuario o la clave son incorrectos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimpiarTxt();
            }
            

        }
    }
}
