using System.ComponentModel.DataAnnotations;

namespace Commandar.Models
{
    public class Command
    {
         public int Id { get; set; }   

         [Required]
         [MaxLength(250)]
         public string  HowTo { get; set; }   

         [Required]
         public string Line { get; set; }  


        [Required]
         public string platform { get; set; }
    }
}