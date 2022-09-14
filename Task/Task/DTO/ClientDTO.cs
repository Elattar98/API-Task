using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.DTO
{
    public enum currency
    {
        EGP, Euro, Dollar
    }
    public enum accountType
    {
        Current, Saving, Deposit
    }
    public class ClientDTO
    {
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        public decimal OpeningBalance { get; set; }
        [Required]
        public currency Currency { get; set; }
        [Required]
        public accountType AccountType { get; set; }
        [Required]
        public int BankId { get; set; }
    }
}
