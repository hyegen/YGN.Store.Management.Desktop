using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            bool result = _clientDal.AddClient(client);
            return result ? true : false;
        }
        public List<Client> GetClients() => _clientDal.GetAll();
        public void UpdateClient(Client client)
        {
            if (client != null)
            {
                _clientDal.Update(client);
            }
            else
            {
                return;
            }
        }
        public void DeleteClient(Client client)
        {
            if (client != null)
            {
                _clientDal.Delete(client);
            }
        }
        public List<Client> GetAllClientsByNameAndSurname()
        {
            return _clientDal.GetAllClientsByNameAndSurname();
        }
        public List<ClientCodeAndNameAndSurnameView> GetClientCodeAndNameAndSurname()
        {
            var result = _clientDal.GetClientCodeAndNameAndSurname();
            if (result.Count() > 0 || result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public int GetClientIdByOrderId(int orderId)
        {
            if (orderId != 0)
            {
                return _clientDal.GetClientIdByOrderId(orderId);
            }
            else
            {
                return 0;
            }
        }
    }

}
