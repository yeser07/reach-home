using System.ComponentModel.DataAnnotations;

namespace Reach_Home.Models
{
    public class Ubicacion
    {
        [Key]
        public int ubicacion_id {get; set;}

        [Required]
        [MaxLength(150)] 
        [StringLength(150, ErrorMessage = "La dirección debe tener como máximo 150 caracteres.")]
        public string ubicacion_direccion {get;set;}

        [Required]
        [MaxLength(20)] 
        [StringLength(20, ErrorMessage = "El Pais debe tener como máximo 20 caracteres.")]
        public string ubicacion_pais {get;set;}

        [Required]
        [MaxLength(50)] 
        [StringLength(50, ErrorMessage = "El estado debe tener como máximo 50 caracteres.")]
        public string ubicacion_estado {get;set;}

        [Required]
        [MaxLength(50)] 
        [StringLength(50, ErrorMessage = "La ciudad debe tener como máximo 50 caracteres.")]
        public string ubicacion_ciudad {get;set;}

        [Required]
        [MaxLength(30)] 
        [StringLength(30, ErrorMessage = "La colonia debe tener como máximo 30 caracteres.")]
        public string ubicacion_colonia {get;set;}

        public double ubicacion_longitud {get; set;}

        public double ubicacion_latitud {get; set;}
        
    }
}