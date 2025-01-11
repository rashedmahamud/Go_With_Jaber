using System.ComponentModel.DataAnnotations;

namespace DB_Project.EntityModel
{

   public class Product
   {
          [Key] 
          public int Id { get; set; }
          [Required]
          public string Name {get;set;}

          public string Size {get;set;}

          public string Image {get;set;}

   }

}