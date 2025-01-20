using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace DB_Project.EntityModel
{

   public class Order
   {
          [Key] 
          public int Id { get; set; }
          [Required]
          public DateTime Date  {get;set;}
          public string Description {get;set;}

          public int Status {get;set;}

         public double Amount { get; set; }

          public string? Address {get;set;}
          
          [Required]    
          public string Email {get;set;}
        
          public Customer customer {get;set;}
          public int CustomerId { get; set; }

   }

}