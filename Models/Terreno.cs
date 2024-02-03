using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reach_Home.Models
{
    public class Terreno
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int terreno_id { get; set; }

        [ForeignKey("Ubicacion")]
        public int terreno_ubicacion_id {get; set;}
        public Ubicacion Ubicacion { get; set; }

        [Required]
        [MaxLength(50)] 
        [StringLength(50, ErrorMessage = "Tienes un maximo de 50 caracteres para ingresar el tamaño.")]
        public string tamanio {get; set;}

         [ForeignKey("Topografia")]
        public int terreno_topografia_id {get; set;}
        public Topografia Topografia { get; set; }

        [Required]
        [MaxLength(200)] 
        [StringLength(200, ErrorMessage = "Tienes un maximo de 200 caracteres para ingresar las caracteristicas.")]
        public string caracteristicas {get; set;}

        [Required]
        public double precio {get; set;}

        [Required]
        [MaxLength(200)] 
        [StringLength(200, ErrorMessage = "Tienes un maximo de 200 caracteres para ingresar la descripcion.")]
         public string descripcion {get; set;}

         [ForeignKey("Usuario")]
        public int terreno_usuario_id {get; set;}
        public Usuario Usuario { get; set; }

          [ForeignKey("DocumentoLegal")]
        public int terreno_documento_legal_id {get; set;}
        public DocumentoLegal DocumentoLegal { get; set; }
    }
}