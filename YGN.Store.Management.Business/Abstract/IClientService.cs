using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IClientService
    {
        bool AddClient(Client client);
        List<Client> GetClients();
        void UpdateClient(Client client);
        void DeleteClient(Client client);
        int CountOfAllClients();
        List<Client> GetByName(string searchName);
    }
}
