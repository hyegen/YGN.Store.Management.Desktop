using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            if (item != null)
            {
                return _itemDal.AddItem(item) ? true : false;
            }
            else
            {
                return false;
            }
        }
        public void DeleteItem(Item item)
        {
            if (item != null)
            {
                _itemDal.Delete(item);
            }
            else
            {
                return;
            }
        }
        public List<Item> GetItems() => _itemDal.GetItems();
        public double GetUnitPrice(int itemId)
        {
            if (itemId != 0)
            {
                var result = _itemDal.GetUnitPrice(itemId);
                if (result != 0.0)
                {
                    return result;
                }
            }
            return 0.0;
        }
        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                _itemDal.Update(item);
            }
            else
            {
                return;
            }
        }
        public List<MobItemSelectionViews> MobGetItemsView()
        {
            var result = _itemDal.MobGetItemsView();
            if (result.Count() >= 0)
            {
                return result;
            }
            return null;
        }

    }
}
