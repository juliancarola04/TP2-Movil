namespace TP2.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string RutaImagen { get; set; } = string.Empty;

    }
}
