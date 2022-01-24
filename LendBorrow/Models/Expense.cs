using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LendBorrow.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Trošak")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0!")]

        [DisplayName("Cijena")]
        public int Amount { get; set; }
    }
}
