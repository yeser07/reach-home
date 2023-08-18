using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Reach_Home.Models
{
    public class Usuario
    {   
        [Key]
        public int usuario_id {get; set;}

        [Required]
        [MaxLength(50)] 
        [StringLength(50, ErrorMessage = "El nombre debe tener como máximo 50 caracteres.")]
        public string usuario_nombre {get;set;}

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        [DataType(DataType.Password)]
        public string usuario_contrasenia {get; set;}

        [Required]
        [MaxLength(50)] 
        [StringLength(50, ErrorMessage = "El telefono debe tener como máximo 50 caracteres.")]
        public string usuario_telefono {get;set;}

        public bool usuario_activo {get; set;}

        [ForeignKey("Rol")]
        public int usuario_rol_id {get; set;}
        public Rol Rol { get; set; }
    }
}