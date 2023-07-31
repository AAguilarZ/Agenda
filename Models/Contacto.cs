using System.ComponentModel.DataAnnotations;

namespace AgendaContactos.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public string Apellido1 { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public string Apellido2 { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este dato es requerido")]
        public DateTime FechaNacimiento { get; set; }


    }
}
