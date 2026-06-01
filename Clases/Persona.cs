namespace ProyectoFinal.Clases
{
    public class Persona
    {
        protected string nombre;
        protected string contraseña;
        protected string tipo;

        public Persona()
        {
        }

        public Persona(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
    }
}
