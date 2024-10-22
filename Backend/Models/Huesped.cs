using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Huesped
    {
        [Key]
        public int IdHuesped { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }



    }
}
