using Task.DTO;
using Task.Models;

namespace Task.Repositories
{
    public interface IClientRepository
    {
        public List<Client> GetAll();
        public Client GetById(int id);
        public void Insert(ClientDTO client);
        public void Update(int id, Client client);
        public void Delete(int id);
    }
}
