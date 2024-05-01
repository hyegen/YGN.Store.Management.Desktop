using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Business.Concrete
{
    public class ItemManager : IItemService
    {
        private readonly IItemDal _itemDal;
        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }
        public bool AddItem(Item item)
        {
            return _itemDal.AddItem(item);
        }
        public int CountOfAllItems()
        {
            return _itemDal.CountOfAllItems();
        }
        public void DeleteItem(Item item)
        {
            _itemDal.Delete(item);
        }
        public List<Item> GetByName(string searchName)
        {
            return _itemDal.GetByName(searchName);
        }
        public List<Item> GetItems() => _itemDal.GetItems();
        public double GetUnitPrice(int itemId)
        {
            return _itemDal.GetUnitPrice(itemId);
        }
        public void UpdateItem(Item item)
        {
            _itemDal.Update(item);
        }
        public List<MobItemSelectionViews> MobGetItemsView()
        {
            return _itemDal.MobGetItemsView();
        }
    }
}
