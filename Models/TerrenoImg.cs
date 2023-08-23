using System.ComponentModel.DataAnnotations;

namespace Reach_Home.Models
{
    public class TerrenoImg
    {
        [Key]
        public int terrenoimg_id {get; set;}
        public string terrenoimg_img {get; set;}
    }
}