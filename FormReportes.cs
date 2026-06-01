using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Drawing.Imaging;

namespace ProyectoFinal
{
    public partial class FormReportes : Form
    {
        PrintDocument pd = new PrintDocument();

        public FormReportes()
        {
            InitializeComponent();

            pd.PrintPage += ImprimirReporte;

            CargarReportes();
        }

        private void CargarReportes()
        {
            try
            {
                double totalVentas = 0;

                int cantidadVentas = 0;

                Dictionary<string, int> vendidos =
                new Dictionary<string, int>();

                int ventasHoy = 0;

                double gananciasHoy = 0;

                string hoy =
                DateTime.Now.ToShortDateString();


                // VENTAS
                if (File.Exists("ventas.txt"))
                {
                    string[] ventas =
                    File.ReadAllLines("ventas.txt");

                    cantidadVentas = ventas.Length;

                    foreach (string venta in ventas)
                    {
                        string[] datos =
                        venta.Split(',');

                        string fecha =
                       datos[1];

                        string productos =
                        datos[3];

                        double total =
                        Convert.ToDouble(datos[4]);

                        totalVentas += total;

                        // PRODUCTOS VENDIDOS
                        string[] listaProductos =
                        productos.Split('|');

                        foreach (string p in listaProductos)
                        {
                            string producto =
                            p.Trim();

                            if (producto != "")
                            {
                                if (vendidos.ContainsKey(producto))
                                {
                                    vendidos[producto]++;
                                }
                                else
                                {
                                    vendidos.Add(producto, 1);
                                }
                            }
                        }

                        // REPORTE DIARIO
                        if (fecha == hoy)
                        {
                            ventasHoy++;

                            gananciasHoy += total;
                        }
                    }
                }

                // TOTAL VENDIDO
                lblTotalVendido.Text =
                totalVentas.ToString("#,##0");


                // CANTIDAD VENTAS
                lblCantidadVentas.Text =
                cantidadVentas.ToString();


                // MÁS Y MENOS VENDIDO
                string masVendido = "";

                int mayor = 0;

                string menosVendido = "";

                int menor = 9999;

                foreach (var producto in vendidos)
                {
                    // MÁS VENDIDO
                    if (producto.Value > mayor)
                    {
                        mayor = producto.Value;

                        masVendido =
                        producto.Key;
                    }

                    // MENOS VENDIDO
                    if (producto.Value < menor)
                    {
                        menor = producto.Value;

                        menosVendido =
                        producto.Key;
                    }
                }

                lblMasVendido.Text =
                masVendido;

                lblCantidadMasVendido.Text =
                mayor + " ventas";

                lblMenosVendido.Text =
                menosVendido;

                lblCantidadMenosVendido.Text =
                menor + " ventas";


                // REPORTE DIARIO
                lblVentasHoy.Text =
                ventasHoy.ToString();

                lblGananciasHoy.Text =
                "$ " + gananciasHoy.ToString("#,##0");


                // BAJO STOCK
                lstBajoStock.Items.Clear();

                if (File.Exists("productos.txt"))
                {
                    string[] productos =
                    File.ReadAllLines("productos.txt");

                    foreach (string producto in productos)
                    {
                        string[] datos =
                        producto.Split(',');

                        int stock =
                        Convert.ToInt32(datos[3]);

                        if (stock <= 5)
                        {
                            lstBajoStock.Items.Add(
                                datos[0] +
                                " (" + stock + ")"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }


        }


        // IMPRIMIR
        private void btnImprimir_Click(
            object sender,
            EventArgs e
        )
        {
            try
            {
                PrintPreviewDialog vista =
                new PrintPreviewDialog();

                vista.Document = pd;

                vista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );



            }
        }

        private void ImprimirReporte(
            object sender,
            PrintPageEventArgs e
        )
        {
            Font titulo =
            new Font("Arial", 18, FontStyle.Bold);

            Font texto =
            new Font("Arial", 12);

            int y = 100;

            e.Graphics.DrawString(
                "REPORTE GENERAL",
                titulo,
                Brushes.Black,
                250,
                y
            );

            y += 60;

            e.Graphics.DrawString(
                "TOTAL VENDIDO: " +
                lblTotalVendido.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "VENTAS REALIZADAS: " +
                lblTotalVendido.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "PRODUCTO MÁS VENDIDO: " +
                lblVentasHoy.Text +
                " - " +
                lblCantidadMasVendido.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "PRODUCTO MENOS VENDIDO: " +
                lblMenosVendido.Text +
                " - " +
                lblCantidadMenosVendido.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "VENTAS DE HOY: " +
                lblVentasHoy.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 30;

            e.Graphics.DrawString(
                "GANANCIAS DE HOY: " +
                lblGananciasHoy.Text,
                texto,
                Brushes.Black,
                100,
                y
            );

            y += 50;

            e.Graphics.DrawString(
                "PRODUCTOS BAJO STOCK",
                titulo,
                Brushes.Red,
                100,
                y
            );

            y += 40;

            foreach (var item in lstBajoStock.Items)
            {
                e.Graphics.DrawString(
                    item.ToString(),
                    texto,
                    Brushes.Black,
                    120,
                    y
                );

                y += 25;
            }

            y += 50;

           Bitmap bmp = new Bitmap(
          cartesianChart1.Width,
          cartesianChart1.Height
          );

          cartesianChart1.DrawToBitmap(
          bmp,
          new Rectangle(
          0,
          0,
          cartesianChart1.Width,
          cartesianChart1.Height
           )
          );

         bmp.Save(
         "grafica.png",
         ImageFormat.Png
          );

            Image grafica =
            Image.FromFile("grafica.png");

            e.Graphics.DrawImage(
                grafica,
                80,
                y,
                600,
                250
            );


        }



        private void btnActualizar_Click(
            object sender,
            EventArgs e
        )
        {
            CargarReportes();
        }

        private void btnRegresar_Click(
            object sender,
            EventArgs e
        )
        {
            FormMenuPrincipal menu = new FormMenuPrincipal();

            menu.Show();

            this.Close();
        }

        private void CargarGrafica()
        {
            Dictionary<string, double> ventasPorDia =
            new Dictionary<string, double>();

            string[] lineas =
            File.ReadAllLines("ventas.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                string fecha = datos[1];

                double totalVenta =
                Convert.ToDouble(datos[4]);

                if (ventasPorDia.ContainsKey(fecha))
                {
                    ventasPorDia[fecha] += totalVenta;
                }
                else
                {
                    ventasPorDia.Add(fecha, totalVenta);
                }
            }

            List<string> fechas =
            ventasPorDia.Keys.ToList();

            List<double> totales =
            ventasPorDia.Values.ToList();

            cartesianChart1.Series = new ISeries[]
            {
        new ColumnSeries<double>
        {
            Name = "Ventas por día",
            Values = totales
        }
            };

            cartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Name = "Fecha",
            Labels = fechas,
        }
            };

            cartesianChart1.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Total vendido",
             Labeler = value => value.ToString("$#,##0")
        }
            };
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            CargarGrafica();
        }
    }
}