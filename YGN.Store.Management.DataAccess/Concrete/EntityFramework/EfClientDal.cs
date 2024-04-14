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

        public List<Client> GetByName(string searchName)
        {
            using (YGNContext context = new YGNContext())
            {
                //var a = context.Set<Client>().Where(entity => entity.ClientName.StartsWith(searchName, StringComparison.OrdinalIgnoreCase)).ToString();
                //return a;   
                var result = context.Set<Client>()
                    .Where(entity => entity.ClientName.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0) // Büyük küçük harf duyarlılığını dikkate almadan içerme kontrolü yapın
                    .ToList();

                return result;
            }
        }
    }
}
