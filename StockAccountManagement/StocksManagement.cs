using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StockAccountManagement.StocksInventory;

namespace StockAccountManagement
{
    internal class StocksManagement
    {

        int totShares = 0;


        public void AddStock(List<StocksInventory.Stocks> stocks)
        {
            Stocks stocks1 = new Stocks();
            Console.WriteLine("Enter the stock name: ");
            stocks1.StockName = Console.ReadLine();
            Console.WriteLine("Enter number of shares ");
            stocks1.Shares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the stock price: ");
            stocks1.Price = Convert.ToInt32(Console.ReadLine());
            stocks.Add(stocks1);
        }
        public void DeleteInventory(List<StocksInventory.Stocks> stocks)
        {
            Console.WriteLine("Enter the stock name to be deleted: ");
            string temp = Console.ReadLine();
            foreach (var data in stocks)
            {
                if (temp == data.StockName)
                {
                    stocks.Remove(data);
                }
                else
                {
                    Console.WriteLine("Data not present");
                }
            }
        }
        public void DisplayStocks(List<StocksInventory.Stocks> stocksList)
        {
            Console.WriteLine("STOCK DETAILS");
            foreach (var i in stocksList)
            {
                Console.WriteLine("Stock name is: {0} \nStock share is: {1} \nStock Price is: {2}", i.StockName, i.Shares, i.Price);
                int temp = i.Shares * i.Price;
                totShares += temp;
                Console.WriteLine("Total stock price for {0} is : {1}", i.StockName, temp);
            }
            Console.WriteLine("Total store is : {0}", totShares);

        }



    }
}
