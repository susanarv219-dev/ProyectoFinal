using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Linq;


namespace ProyectoFinal
{
    public partial class FormHistorialVentas : Form
    {
        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();

            this.Close();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {

            dgvHistorial.Rows.Clear();

            if (File.Exists("ventas.txt"))
            {
                string[] lineas = File.ReadAllLines("ventas.txt");

                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] datos = linea.Split(',');

                        dgvHistorial.Rows.Add(
                            datos[0],
                            datos[1],
                            datos[2],
                            datos[3],
                            Convert.ToDouble(datos[4]).ToString("$0.00"),
                            datos[5]
                        );
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvHistorial.Rows.Clear();

            string buscar =
            textBox1.Text.ToLower();

            string[] lineas =
            File.ReadAllLines("ventas.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                // datos[0] = numero venta
                // datos[3] = productos

                if (datos[0].ToLower().Contains(buscar) ||
                    datos[3].ToLower().Contains(buscar))
                {
                    dgvHistorial.Rows.Add(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3],
                        Convert.ToDouble(datos[4]).ToString("$0.00"),
                        datos[5]
                    );
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           try
    {
       
        if (FormIniciarSesion.TipoUsuario == "Vendedor")
        {
            throw new Clases.AccesoDenegadoException("Operación inválida: El rol Vendedor no puede eliminar registros del historial de ventas");
        }

        if (dgvHistorial.CurrentRow != null)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas borrar esta venta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int fila = dgvHistorial.CurrentRow.Index;

                List<string> lineas = File.ReadAllLines("ventas.txt").ToList();
                lineas.RemoveAt(fila);
                File.WriteAllLines("ventas.txt", lineas);

                CargarHistorial();
                MessageBox.Show("Venta eliminada con éxito.");
            }
        }
    }
    catch (Clases.AccesoDenegadoException ex)
    {
        MessageBox.Show(ex.Message, "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
    }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvHistorial.Rows.Clear();

            DateTime fechaDesde =
            dateTimePicker1.Value.Date;

            DateTime fechaHasta =
            dateTimePicker2.Value.Date;

            string[] lineas =
            File.ReadAllLines("ventas.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                // datos[1] = fecha
                DateTime fechaVenta =
                Convert.ToDateTime(datos[1]);

                if (fechaVenta >= fechaDesde &&
                    fechaVenta <= fechaHasta)
                {
                    dgvHistorial.Rows.Add(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3],
                        Convert.ToDouble(datos[4]).ToString("$0.00"),
                        datos[5]
                    );
                }
            }
        }
    }

}
