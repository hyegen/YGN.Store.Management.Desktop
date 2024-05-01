using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.DataAccess.Abstract
{
    public interface IClientDal : IEntityRepository<Client>
    {
        bool AddClient(Client client);
        Client GetClientByName(string clientName);
        int CountOfAllClients();
        List<Client> GetAllClientsByNameAndSurname();
        List<ClientCodeAndNameAndSurnameView> GetClientCodeAndNameAndSurname();
    }
}
