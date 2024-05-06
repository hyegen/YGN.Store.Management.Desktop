using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfItemDal : EfGenericRepositoryBase<Item, YGNContext>, IItemDal
    {
        public bool AddItem(Item item)
        {
            using (YGNContext context = new YGNContext())
            {
                var checkItemCodeIfExist = (from i in context.Items
                                            where i.ItemCode == item.ItemCode
                                            select i.ItemCode).ToList();

                if (checkItemCodeIfExist.Count() == 0)
                {
                    context.Items.Add(item);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public int CountOfAllItems()
        {
            using (YGNContext context = new YGNContext())
            {
                return context.Items.Count();
            }
        }
        public List<Item> GetByName(string searchName)
        {
            using (YGNContext context = new YGNContext())
            {
                return context.Set<Item>().Where(entity => entity.ItemName.Equals(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }
        public List<Item> GetItems()
        {
            using (YGNContext context = new YGNContext())
            {
                return context.Set<Item>().ToList();
            }
        }
        public double GetUnitPrice(int itemId)
        {
            using (YGNContext context = new YGNContext())
            {
                var result = (from i in context.Items
                              where i.Id == itemId
                              select i.UnitPrice).FirstOrDefault();
                return (double)result;
            }
        }
        public List<MobItemSelectionViews> MobGetItemsView()
        {
            using (YGNContext context = new YGNContext())
            {
                var stockAmounts = context.Database.SqlQuery<MobItemSelectionViews>("EXEC YGN_MOB_ITEM_SELECTION_VIEW").ToList();
                return stockAmounts;
            }
        }
        public int GetItemIdByOrderId(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var result = (from ord in context.Orders
                              join orl in context.OrderLines on ord.Id equals orl.OrderId
                              join itm in context.Items on orl.ItemId equals itm.Id
                              where ord.Id == orderId
                              select itm.Id).FirstOrDefault();
                return result;
            }
        }
        //public int GetItemIdByOrderId(string itemCode)
        //{
        //    using (YGNContext context = new YGNContext())
        //    {
        //        var result = (from ord in context.Orders
        //                      join orl in context.OrderLines on ord.Id equals orl.OrderId
        //                      join itm in context.Items on orl.ItemId equals itm.Id
        //                      where itm.ItemCode == itemCode
        //                      select itm.Id).FirstOrDefault();
        //        return result;
        //    }
        //}
    }
}
