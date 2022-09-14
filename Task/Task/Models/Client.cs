using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal OpeningBalance { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        [ForeignKey("Bank")]
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
