using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    public class Login
    {
        [Required(ErrorMessage = "El usuario es obligatorio.")]
        public string Usuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "La clave es obligatoria.")]
        public string Clave { get; set; } = string.Empty;
    }
}
