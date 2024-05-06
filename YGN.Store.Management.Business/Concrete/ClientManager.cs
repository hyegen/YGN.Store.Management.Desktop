using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.Business.Concrete
{
    public class ClientManager : IClientService
    {
        private readonly IClientDal _clientDal;
        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }
        public bool AddClient(Client client)
        {
            return _clientDal.AddClient(client);
        }
        public List<Client> GetClients() => _clientDal.GetAll();
        public void UpdateClient(Client client)
        {
            _clientDal.Update(client);
        }
        public void DeleteClient(Client client)
        {
            _clientDal.Delete(client);
        }
        public int CountOfAllClients()
        {
            return _clientDal.CountOfAllClients();
        }

        public List<Client> GetAllClientsByNameAndSurname()
        {
            return _clientDal.GetAllClientsByNameAndSurname();
        }

        public List<ClientCodeAndNameAndSurnameView> GetClientCodeAndNameAndSurname()
        {
            return _clientDal.GetClientCodeAndNameAndSurname();
        }

        public int GetClientIdByOrderId(int orderId)
        {
           return _clientDal.GetClientIdByOrderId(orderId);
        }
    }

}
