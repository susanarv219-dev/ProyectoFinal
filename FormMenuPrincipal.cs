using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario inventario = new FormInventario();
            inventario.Show();

            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta();
            venta.Show();

            this.Hide();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialVentas historial = new FormHistorialVentas();
            historial.Show();

            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes reportes = new FormReportes();
            reportes.Show();

            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesion login = new FormIniciarSesion();

            login.Show();

            this.Close();
        }

        private void CargarResumen()
        {
            // PRODUCTOS REGISTRADOS
            if (File.Exists("productos.txt"))
            {
                string[] productos =
                File.ReadAllLines("productos.txt");

                lblProductos.Text =
                productos.Length.ToString();
            }

            // TOTAL EN VENTAS
            double totalVentas = 0;

            if (File.Exists("ventas.txt"))
            {
                string[] ventas =
                File.ReadAllLines("ventas.txt");

                foreach (string venta in ventas)
                {
                    string[] datos = venta.Split(',');

                    // datos[4] = total
                    totalVentas +=
                    Convert.ToDouble(datos[4]);
                }
            }

            lblVentas.Text = totalVentas.ToString("$#,##0");

            // PRODUCTOS BAJO STOCK
            int bajoStock = 0;

            if (File.Exists("productos.txt"))
            {
                string[] productos =
                File.ReadAllLines("productos.txt");

                foreach (string producto in productos)
                {
                    string[] datos = producto.Split(',');

                    // datos[3] = stock
                    int stock =
                    Convert.ToInt32(datos[3]);

                    if (stock <= 5)
                    {
                        bajoStock++;
                    }
                }
            }

            lblStock.Text =
            bajoStock.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CargarResumen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
  MessageBox.Show(
      "¿Deseas salir de la aplicación?",
      "Confirmar salida",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
  );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
