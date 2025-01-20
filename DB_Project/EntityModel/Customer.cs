using System.ComponentModel.DataAnnotations;

namespace DB_Project.EntityModel
{

   public class Customer
   {
          [Key] 
          public int Id { get; set; }
          [Required]
          public string Name {get;set;}
          [Required]
          public string PhoneNumber {get;set;}

          public string? Address {get;set;}
          
          [Required]    
          public string Email {get;set;}

   }

}