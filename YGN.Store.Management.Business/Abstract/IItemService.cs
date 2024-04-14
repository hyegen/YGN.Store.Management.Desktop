using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IItemService
    {
        bool AddItem(Item item);
        List<Item> GetItems();
        void UpdateItem(Item item);
        void DeleteItem(Item item);
        int CountOfAllItems();
        List<Item> GetByName(string searchName);
        double GetUnitPrice(int itemId);
    }
}
