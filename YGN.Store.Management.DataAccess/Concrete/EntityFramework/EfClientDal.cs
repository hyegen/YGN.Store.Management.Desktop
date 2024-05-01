using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.Core.Entities;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfClientDal : EfGenericRepositoryBase<Client, YGNContext>, IClientDal
    {
        public bool AddClient(Client client)
        {
            using (YGNContext context = new YGNContext())
            {
                var checkClientCode = (from c in context.Clients
                                       where c.ClientCode == client.ClientCode
                                       select c.ClientCode).ToList();

                if (checkClientCode.Count() == 0)
                {
                    context.Clients.Add(client);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public int CountOfAllClients()
        {
            using (YGNContext context = new YGNContext())
            {
                var count = context.Clients.Count();
                return count;
            }
        }
        public List<Client> GetAllClientsByNameAndSurname()
        {
            using (YGNContext context = new YGNContext())
            {
                var clients = context.Clients.ToList();
                return clients;
            }
        }
        public Client GetClientByName(string client)
        {
            using (YGNContext context = new YGNContext())
            {
                var query = from c in context.Clients
                            where c.ClientName.Contains(client)
                            select c;

                return query.FirstOrDefault();
            }
        }
        public List<ClientCodeAndNameAndSurnameView> GetClientCodeAndNameAndSurname()
        {
            using (YGNContext context = new YGNContext())
            {
                var clients = context.Clients.ToList();
                var result = clients.Select(c => new ClientCodeAndNameAndSurnameView
                {
                    ClientId=c.Id,
                    ClientCodeAndNameAndSurname = $"{c.ClientCode}-{c.ClientName} {c.ClientSurname}"
                }).ToList();

                return result;
            }
        }
    }
}
