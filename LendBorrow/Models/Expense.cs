using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //[DisplayName("Tip troška")]
       public int ExpenseTypeId { get; set; }
        [DisplayName("Tip Troška")]
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
