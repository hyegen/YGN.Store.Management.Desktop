﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Entities.Views
{
    public class StockAmountView
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int StockAmount { get; set; }
    }
}
