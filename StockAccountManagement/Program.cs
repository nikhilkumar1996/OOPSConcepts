using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StocksManagement management = new StocksManagement();
            string file = @"E:\github\OOPSConcepts\StockAccountManagement\Stock.json";
            StocksInventory inventory = JsonConvert.DeserializeObject<StocksInventory>(File.ReadAllText(file));
            Console.WriteLine("Enter which operation to perform\n 1 Add a stock\n 2 Remove a stock\n 3 Display Stocks");
            int num = Convert.ToInt32(Console.ReadLine());
            var stockfn = inventory.stocksList;
            switch (num)
            {
                case 1:
                    management.AddStock(stockfn);
                    File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                    management.DisplayStocks(stockfn);
                    break;
                case 2:
                    management.DeleteInventory(stockfn);
                    File.WriteAllText(file, JsonConvert.SerializeObject(inventory));
                    management.DisplayStocks(stockfn);
                    break;
                case 3:
                    management.DisplayStocks(stockfn);
                    break;
            }
        }
    }
}
