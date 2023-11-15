using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAndRegistration.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Por favor proporciona este dato")]
        [MinLength(2, ErrorMessage = "Tu nombre debe tener al menos 2 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor proporciona este dato")]
        [MinLength(2, ErrorMessage = "Tu apellido debe tener al menos 2 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor proporciona este dato")]
        [EmailAddress(ErrorMessage = "Por favor proporciona un correo válido.")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor proporciona este dato")]
        [MinLength(8, ErrorMessage = "Tu contraseña debe tener al menos 8 caracteres.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string PasswordConfirm { get; set; }
    }
}

