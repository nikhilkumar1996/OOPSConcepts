using OOPSConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"E:\github\OOPSConcepts\InventoryManagementSystem\Inventory.json");
            Console.ReadKey();
        }
    }
}
