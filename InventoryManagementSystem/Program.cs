using Newtonsoft.Json;
using System;
using System.IO;

namespace InventoryManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            string file = @"E:\github\OOPSConcepts\InventoryManagementSystem\Inventory.json";
            Inventory inventory = JsonConvert.DeserializeObject<Inventory>(File.ReadAllText(file));
            var listRice = inventory.RiceList;
            var listWheat=inventory.WheatList;
            var listPulses = inventory.PulseList;
            Console.WriteLine("Choose options" +
                              "\n 1)Add Items " +
                              "\n 2)Delete Rice Items " +
                              "\n 3)Delete Wheat Items" +
                              "\n 4)Delete Pulse Items" +
                              "\n 5)Display" +
                              "\n 6) EXIT");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter List of Options:");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        inventoryManagement.AddInventory(listRice,listWheat,listPulses);
                        File.WriteAllText(file, JsonConvert.SerializeObject(inventory));

                        break;

                    case 2:
                        inventoryManagement.DeleteRiceInventory(listRice);
                        break;

                    case 3:
                        inventoryManagement.DeleteWheatInventory(listWheat);
                        break;

                    case 4:
                        inventoryManagement.DeletePulsesInventory(listPulses);
                        break;

                    case 5:
                        inventoryManagement.DisplayInventory(listRice, listWheat, listPulses);
                        break;

                    case 6:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect option");
                        break;
                }
            }
        }

    }
}