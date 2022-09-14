using Microsoft.EntityFrameworkCore;

namespace Task.Models
{
    public class BankEntity: DbContext
    {
        public BankEntity() { }
        public BankEntity(DbContextOptions options) : base(options) { }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BankDBDemo;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
