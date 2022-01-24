using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LendBorrow.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Uzima")]
        public string Borrower { get; set; }

        [DisplayName("Posuđuje")]
        public string Lender { get; set; }

        [DisplayName("Predmet")]
        public string ItemName { get; set; }
    }
}
