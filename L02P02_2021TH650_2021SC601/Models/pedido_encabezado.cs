namespace L02P02_2021TH650_2021SC601.Models
{
    public class pedido_encabezado
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int cantidad_libros { get; set; }
        public double total { get; set; }
    }
}
