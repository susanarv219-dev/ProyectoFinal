using ProyectoFinal.Clases;

namespace ProyectoFinal
{
    public partial class FormIniciarSesion : Form
    {
        public static string TipoUsuario = "";
        public FormIniciarSesion()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador admin = new Administrador();

                bool acceso = admin.IniciarSesion(
                    txtUsuario.Text,
                    txtContraseña.Text
                );

                if (acceso)
                {
                    MessageBox.Show( "Bienvenido " +
                    FormIniciarSesion.TipoUsuario
);
                    txtContraseña.Clear();

                    FormMenuPrincipal menu = new FormMenuPrincipal();

                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos"
                    );

                    txtContraseña.Clear();

                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
        }


    }
}
