using System;
using System.IO;
using System.Windows.Forms;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Clases
{
    public class Usuario : Persona, IUsuario
    {
        public virtual bool IniciarSesion(string usuario, string contraseña)
        {
            try
            {
                string ruta = "usuarios.txt";

                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No existe el archivo");
                    return false;
                }

                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    if (datos[0] == usuario &&
                        datos[1] == contraseña)
                    {
                        FormIniciarSesion.TipoUsuario = datos[2];

                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
    public class AccesoDenegadoException : Exception
    {
        public AccesoDenegadoException(string mensaje) : base(mensaje) { }
    }
}