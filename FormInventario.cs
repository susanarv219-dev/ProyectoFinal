using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoFinal.Clases;
using System.IO;

namespace ProyectoFinal
{
    public partial class FormInventario : Form
    {
        List<Producto> productos = new List<Producto>();
        public FormInventario()
        {
            InitializeComponent();


            cmbCategoria.Items.Add("Medicamento");
            cmbCategoria.Items.Add("Crema");
            cmbCategoria.Items.Add("Limpieza");
            cmbCategoria.Items.Add("Dermatológico");

            cmbFiltroCategoria.Items.Add("Todos");
            cmbFiltroCategoria.Items.Add("Medicamento");
            cmbFiltroCategoria.Items.Add("Crema");
            cmbFiltroCategoria.Items.Add("Limpieza");
            cmbFiltroCategoria.Items.Add("Dermatológico");

            cmbFiltroCategoria.SelectedIndex = 0;

            CargarProductos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();

            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (FormIniciarSesion.TipoUsuario == "Vendedor")
                {
                    throw new Clases.AccesoDenegadoException("Acceso restringido: El rol Vendedor no tiene permisos de modificar en el inventario.");
                }

              
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Por favor, llena los campos obligatorios.");
                    return; 
                }

         
                Producto p = new Producto(
                    txtNombre.Text,
                    txtID.Text,
                    Convert.ToDouble(txtPrecio.Text),
                    Convert.ToInt32(numStock.Value),
                    dtpCaducidad.Value.ToShortDateString(),
                    cmbCategoria.Text
                );

              

                MessageBox.Show("Producto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Clases.AccesoDenegadoException ex)
            {
             
                MessageBox.Show(ex.Message, "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarArchivo()
        {
            try
            {
                StreamWriter sw = new StreamWriter("productos.txt");

                foreach (Producto p in productos)
                {
                    sw.WriteLine(
                        p.Nombre + "," +
                        p.ID + "," +
                        p.Precio + "," +
                        p.Stock + "," +
                        p.Caducidad + "," +
                        p.Categoria
                    );
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                if (File.Exists("productos.txt"))
                {
                    string[] lineas = File.ReadAllLines("productos.txt");

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');

                        Producto p = new Producto();

                        p.Nombre = datos[0];
                        p.ID = datos[1];
                        p.Precio = Convert.ToDouble(datos[2]);
                        p.Stock = Convert.ToInt32(datos[3]);
                        p.Caducidad = datos[4];
                        p.Categoria = datos[5];

                        productos.Add(p);

                        dgvProductos.Rows.Add(
                            p.Nombre,
                            p.ID,
                            p.Precio,
                            p.Stock,
                            p.Caducidad,
                            p.Categoria
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FormIniciarSesion.TipoUsuario == "Vendedor")
            {
                MessageBox.Show(
                    "Solo el administrador puede eliminar productos"
                );

                return;
            }
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    int fila =
                        dgvProductos.CurrentRow.Index;

                    productos.RemoveAt(fila);

                    dgvProductos.Rows.RemoveAt(fila);

                    GuardarArchivo();

                    MessageBox.Show(
                        "Producto eliminado"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (FormIniciarSesion.TipoUsuario == "Vendedor")
            {
                MessageBox.Show(
                    "Solo el administrador puede editar productos"
                );

                return;
            }

            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    int fila =
                        dgvProductos.CurrentRow.Index;

                    productos[fila].Nombre =
                        txtNombre.Text;

                    productos[fila].Precio =
                        Convert.ToDouble(txtPrecio.Text);

                    productos[fila].Stock =
                        Convert.ToInt32(numStock.Value);

                    productos[fila].Caducidad =
                        dtpCaducidad.Value
                        .ToShortDateString();

                    productos[fila].Categoria =
                        cmbCategoria.Text;

                    productos[fila].ID = txtID.Text;

                    dgvProductos.Rows[fila].Cells[0].Value =
                        txtNombre.Text;

                    dgvProductos.Rows[fila].Cells[2].Value =
                        txtPrecio.Text;

                    dgvProductos.Rows[fila].Cells[3].Value =
                        numStock.Value;

                    dgvProductos.Rows[fila].Cells[4].Value =
                        dtpCaducidad.Value
                        .ToShortDateString();

                    dgvProductos.Rows[fila].Cells[5].Value =
                        cmbCategoria.Text;

                    dgvProductos.Rows[fila].Cells[1].Value =
                        txtID.Text;

                    GuardarArchivo();

                    MessageBox.Show(
                        "Producto editado"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Clear();

                string nombreBuscar =
                    txtBuscar.Text.ToLower();

                string categoria =
                    cmbFiltroCategoria.Text;

                foreach (Producto p in productos)
                {
                    bool coincideNombre =
                        p.Nombre.ToLower()
                        .Contains(nombreBuscar);

                    bool coincideCategoria =
                        categoria == "Todos" ||
                        p.Categoria == categoria;

                    if (coincideNombre &&
                        coincideCategoria)
                    {
                        dgvProductos.Rows.Add(
                            p.Nombre,
                            p.ID,
                            p.Precio,
                            p.Stock,
                            p.Caducidad,
                            p.Categoria
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila =
                        dgvProductos.Rows[e.RowIndex];

                    txtNombre.Text =
                        fila.Cells[0].Value.ToString();

                    txtID.Text =
                        fila.Cells[1].Value.ToString();

                    txtPrecio.Text =
                        fila.Cells[2].Value.ToString();

                    numStock.Value =
                        Convert.ToInt32(
                            fila.Cells[3].Value
                        );

                    dtpCaducidad.Value =
                        Convert.ToDateTime(
                            fila.Cells[4].Value
                        );

                    cmbCategoria.Text =
                        fila.Cells[5].Value.ToString();

                    txtID.Text =
                       fila.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            txtID.Clear();

            txtPrecio.Clear();

            numStock.Value = 0;

            cmbCategoria.SelectedIndex = -1;

            txtNombre.Focus();
        }
    }

}
