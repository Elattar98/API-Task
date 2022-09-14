using Task.DTO;
using Task.Models;

namespace Task.Repositories
{
    public class ClientRepository : IClientRepository
    {
        BankEntity context;
        public ClientRepository(BankEntity context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Client client = GetById(id);
            context.Remove(client);
            context.SaveChanges();
        }

        public List<Client> GetAll()
        {
            List<Client> clients = context.Clients.ToList();
            return clients;
        }

        public Client GetById(int id)
        {

                Client client = context.Clients.FirstOrDefault(x => x.Id == id);
                return client;
            
        }

        public void Insert(ClientDTO client)
        {
            Client newclient = new Client();
            newclient.Currency = client.Currency.ToString();
            newclient.AccountNumber = client.AccountNumber;
            newclient.AccountType = client.AccountType.ToString();
            newclient.Name = client.Name;
            newclient.BankId = client.BankId;
            newclient.OpeningBalance = client.OpeningBalance;

            context.Clients.Add(newclient);
            context.SaveChanges();
        }

        public void Update(int id, Client client)
        {
            Client updatedclient = GetById(id);
            updatedclient.Name = client.Name;
            updatedclient.AccountNumber = client.AccountNumber;
            updatedclient.AccountType = client.AccountType;
            updatedclient.Currency = client.Currency;
            updatedclient.OpeningBalance = client.OpeningBalance;
            updatedclient.Bank = context.Banks.FirstOrDefault(x => x.Id == client.BankId);
            context.SaveChanges();
        }
    }
}
