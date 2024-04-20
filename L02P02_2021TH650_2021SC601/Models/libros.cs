using System.ComponentModel.DataAnnotations;

namespace L02P02_2021TH650_2021SC601.Models
{
    public class libros
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de libro")]
        public string? nombre { get; set; }
        [Display(Name = "descripcion de libro")]
        public string? descripcion { get; set; }
        [Display(Name = "url de imagen")]
        public string? url_imagen { get; set; }
        [Display(Name = "id del autor")]
        public int id_autor { get; set; }
        [Display(Name = "creacion")]
        public int id_categoria { get; set; }
        [Display(Name = "creacion")]
        public double precio { get; set; }
        [Display(Name = "creacion")]
        public string? estado { get; set; }
    }
}
