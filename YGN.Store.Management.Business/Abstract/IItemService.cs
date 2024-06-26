﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IItemService
    {
        bool AddItem(Item item);
        List<Item> GetItems();
        void UpdateItem(Item item);
        void DeleteItem(Item item);
        double GetUnitPrice(int itemId);
        List<MobItemSelectionViews> MobGetItemsView();
    }
}
