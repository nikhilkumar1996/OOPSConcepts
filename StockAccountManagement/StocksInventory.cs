using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class StocksInventory
    {
        public List<Stocks> stocksList { get; set; }

        public class Stocks
        {
            public string StockName { get; set; }
            public int Shares { get; set; }
            public int Price { get; set; }

        }
    }
}
