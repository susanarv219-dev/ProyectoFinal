using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace ProyectoFinal
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        double total = 0;

        int numeroVenta;

        private void Form4_Load(object sender, EventArgs e)
        {
            cbMetodo.Items.Add("Efectivo");
            cbMetodo.Items.Add("Tarjeta");

            cbMetodo.SelectedIndex = 0;

            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvCarrito.DefaultCellStyle.ForeColor = Color.Black;
            dgvCarrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCarrito.DefaultCellStyle.SelectionForeColor = Color.Black;

            CargarProductos();

            if (File.Exists("ventas.txt"))
            {
                string[] lineas =
                File.ReadAllLines("ventas.txt");

                numeroVenta = lineas.Length + 1;
            }
            else
            {
                numeroVenta = 1;
            }
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();

            this.Close();
        }

        private void CargarProductos()
        {
            dgvProductos.Rows.Clear();

            string[] lineas =
            File.ReadAllLines("productos.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                dgvProductos.Rows.Add(
                    datos[1], // ID
                    datos[0], // Nombre
                    datos[2]  // Precio
                );
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();

            string[] lineas =
            File.ReadAllLines("productos.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                if (datos[0].ToLower().Contains(
                    txtBuscar.Text.ToLower()))
                {
                    dgvProductos.Rows.Add(
                        datos[1],
                        datos[0],
                        datos[2]
                    );
                }
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCarrito.AllowUserToAddRows = false;
            dgvProductos.AllowUserToAddRows = false;
            string id =
    dgvProductos.CurrentRow.Cells[0].Value.ToString();

            string producto =
            dgvProductos.CurrentRow.Cells[1].Value.ToString();

            double precio =
            Convert.ToDouble(
            dgvProductos.CurrentRow.Cells[2].Value);

            int stock = 0;

            string[] lineas =
            File.ReadAllLines("productos.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                // datos[1] = ID
                if (datos[1] == id)
                {
                    stock =
                    Convert.ToInt32(datos[3]);

                    break;
                }
            }

            // SIN STOCK 
            if (stock <= 0)
            {
                MessageBox.Show(
                "Producto sin stock",
                "Stock",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            int cantidad = 1;

            double subtotal = precio * cantidad;

            dgvCarrito.Rows.Add(
                producto,
                precio,
                cantidad,
                subtotal
            );

            total += subtotal;

            lblTotal.Text =
            "$" + total.ToString("0.00");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                dgvCarrito.Rows.Remove(
                dgvCarrito.CurrentRow);

                total = 0;

                foreach (DataGridViewRow fila in dgvCarrito.Rows)
                {
                    if (fila.Cells[3].Value != null)
                    {
                        double subtotal;

                        if (double.TryParse(
                            fila.Cells[3].Value.ToString(),
                            out subtotal))
                        {
                            total += subtotal;
                        }
                    }
                }

                lblTotal.Text =
                "$" + total.ToString("0.00");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos");
                return;
            }

            if (cbMetodo.Text == "Efectivo" &&
            txtDinero.Text == "")
            {
                MessageBox.Show(
                "Debes ingresar el dinero",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            List<string> nuevasLineas =
            new List<string>();

            string[] lineas =
            File.ReadAllLines("productos.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                foreach (DataGridViewRow fila in dgvCarrito.Rows)
                {
                    if (fila.Cells[0].Value != null)
                    {
                        string nombreProducto =
                        fila.Cells[0].Value.ToString();

                        int cantidadVendida =
                        Convert.ToInt32(
                        fila.Cells[2].Value);

                        // datos[0] = Nombre
                        if (datos[0] == nombreProducto)
                        {
                            int stock =
                            Convert.ToInt32(datos[3]);

                            stock -= cantidadVendida;

                            datos[3] = stock.ToString();
                        }
                    }
                }

                nuevasLineas.Add(
                string.Join(",", datos));
            }

            File.WriteAllLines(
            "productos.txt",
            nuevasLineas);

            string productos = "";

            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    productos +=
                    fila.Cells[0].Value.ToString()
                    + " | ";
                }
            }

            using (StreamWriter sw =
            new StreamWriter("ventas.txt", true))
            {
                sw.WriteLine(
                    numeroVenta + "," +
                    DateTime.Now.ToShortDateString() + "," +
                    DateTime.Now.ToShortTimeString() + "," +
                    productos + "," +
                    total + "," +
                    cbMetodo.Text
                );
            }



            numeroVenta++;

            MessageBox.Show("Venta realizada");

            dgvCarrito.Rows.Clear();

            total = 0;

            lblTotal.Text = "$0.00";

            txtDinero.Clear();
            txtCambio.Clear();

            cbMetodo.SelectedIndex = 0;

            CargarProductos();
        }

        private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cbMetodo.Text == "Tarjeta")
            {
                txtDinero.Enabled = false;
                txtCambio.Enabled = false;

                txtDinero.Text = "";
                txtCambio.Text = "";
            }
            else
            {
                txtDinero.Enabled = true;
                txtCambio.Enabled = true;
            }

            double dinero;

            if (txtDinero.Text == "")
            {
                txtCambio.Clear();
                return;
            }

            if (double.TryParse(txtDinero.Text, out dinero))
            {
                double cambio = dinero - total;

                txtCambio.Text =
                cambio.ToString("$0.00");
            }
            else
            {
                txtCambio.Clear();
            }
        }

        private void txtDinero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDinero.Text == "")
                {
                    txtCambio.Clear();
                    return;
                }

                double dinero =
                Convert.ToDouble(txtDinero.Text);

                double cambio =
                dinero - total;

                txtCambio.Text =
                cambio.ToString("$0.00");
            }
            catch
            {
                MessageBox.Show(
                "Solo debes ingresar números");

                txtDinero.Clear();
            }
        }

        private void txtDinero_Enter(object sender, EventArgs e)
        {
            if (txtDinero.Text == "$0.00")
            {
                txtDinero.Clear();
            }
        }
    }
}
   