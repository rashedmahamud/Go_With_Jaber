using System.ComponentModel.DataAnnotations;


namespace DB_Project.EntityModel
{

   public class OrderDetails
   {
        [Key] 
          public int Id { get; set; }
         public int ProductId { get; set; }
         public Product Product  { get; set; }

         public int OderId { get; set; }

         public Order Order  { get; set; }

         public double Qty { get; set; }

   }

}