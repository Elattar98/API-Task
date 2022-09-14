using Task.DTO;
using Task.Models;

namespace Task.Repositories
{
    public interface IBankRepository
    {
        public List<Bank> GetAll();
        public Bank GetById(int id);
        public void Insert(Bank bank);
        public void Update(int id, Bank bank);
        public void Delete(int id);
    }
}
