using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.DataAccess.Abstract
{
    public interface IItemDal : IEntityRepository<Item>
    {
        bool AddItem(Item item);
        List<Item> GetItems();
        int CountOfAllItems();
        List<Item> GetByName(string searchName);
        double GetUnitPrice(int itemId);
        List<MobItemSelectionViews> MobGetItemsView();
        int GetItemIdByOrderId(int orderId);
    }
}
