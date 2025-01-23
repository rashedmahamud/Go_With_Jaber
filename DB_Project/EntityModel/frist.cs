using System.ComponentModel.DataAnnotations;

namespace DB_Project.EntityModel
{
    public class frist
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Name{get;set;}

            public string Size {get;set;}
            
    }



}