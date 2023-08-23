using System.ComponentModel.DataAnnotations;

namespace Reach_Home.Models
{
    public class Topografia
    {
        [Key]
        public int topografia_id {get; set;}

        [MaxLength(50)] 
        public string topografia_descripcion {get; set;}

        public bool topografia_activo {get; set;}

    }
}