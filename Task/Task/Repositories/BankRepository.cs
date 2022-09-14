using Task.Models;

namespace Task.Repositories
{
    public class BankRepository : IBankRepository
    {
        BankEntity context;
        public BankRepository(BankEntity context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bank> GetAll()
        {
            List<Bank> banks = context.Banks.ToList();
            return banks;
        }

        public Bank GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Bank bank)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Bank bank)
        {
            throw new NotImplementedException();
        }
    }
}
