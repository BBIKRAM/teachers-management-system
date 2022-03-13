using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Expenses
    {
        [Key]
        public int Id{get; set;}
        /*[DisplayName("Expanses")]*/
        [Required]
        public string Expanse{get; set;} 
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="amount myst be greater then 1")]
        public int Amount { get; set;} 
    }
}
