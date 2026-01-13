using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Registration
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Introduce un correo electrónico válido.")]
        [StringLength(200, ErrorMessage = "El correo no puede exceder 200 caracteres.")]
        public string Email { get; set; } = string.Empty;
    }
}
