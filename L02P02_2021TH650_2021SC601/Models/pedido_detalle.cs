namespace L02P02_2021TH650_2021SC601.Models
{
    public class pedido_detalle
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public string? id_libro { get; set; }
        public DateTime created_at { get; set; }
    }
}
