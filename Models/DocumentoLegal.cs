using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Reach_Home.Models
{
    public class DocumentoLegal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int documento_legal_id { get; set; }
        public string documento_legal__descripcion { get; set; }
    }
}