using System.ComponentModel.DataAnnotations;

namespace L02P02_2021TH650_2021SC601.Models
{
    public class categorias
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de categoría")]
        public string? categoria { get; set; }
    }
}
