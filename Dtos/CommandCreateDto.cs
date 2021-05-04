using System.ComponentModel.DataAnnotations;

namespace Commandar.Dtos
{
    public class CommandCreateDto
    {


         [Required]
         public int Id { get; set; }   

         [Required]
         public string  HowTo { get; set; }   

       [Required]
         public string Line { get; set; }  
      
      [Required]
        public string platform { get; set; }
    
    }
}