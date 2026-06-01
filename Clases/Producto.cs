namespace ProyectoFinal.Clases
{
    public class Producto
    {
        public string Nombre { get; set; }

        public string ID { get; set; }

        public double Precio { get; set; }

        public int Stock { get; set; }

        public string Caducidad { get; set; }

        public string Categoria { get; set; }

        public Producto()
        {
        }

        public Producto(
            string nombre,
            string id,
            double precio,
            int stock,
            string caducidad,
            string categoria
        )
        {
            Nombre = nombre;
            ID = id;
            Precio = precio;
            Stock = stock;
            Caducidad = caducidad;
            Categoria = categoria;
        }
    }
}
