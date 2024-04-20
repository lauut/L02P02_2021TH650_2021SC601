using System.ComponentModel.DataAnnotations;

namespace L02P02_2021TH650_2021SC601.Models
{
    public class clientes
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre de cliente")]
        public string? nombre { get; set; }
        [Display(Name = "apellido cliente")]
        public string? apellido { get; set; }
        [Display(Name = "email de cliente")]
        public string? email { get; set; }
        [Display(Name = "direccion del cliente")]
        public string? direccion { get; set; }
        [Display(Name = "creacion")]
        public DateTime created_at { get; set; }
    }
}
