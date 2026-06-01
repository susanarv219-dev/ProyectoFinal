using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class Administrador : Usuario
    {
        public override bool IniciarSesion(
            string usuario,
            string contraseña)
        {
            return base.IniciarSesion(
                usuario,
                contraseña
            );
        }
    }
}