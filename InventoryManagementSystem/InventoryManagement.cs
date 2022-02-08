using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InventoryManagementSystem.Inventory;

namespace InventoryManagementSystem
{
    public class InventoryManagement
    {
        List<Rice> riceList = new List<Rice>();
        List<Wheat> wheatList = new List<Wheat>();
        List<Pulse> pulseList = new List<Pulse>();
        Rice rice = new Rice();
        Wheat wheat = new Wheat();
        Pulse pulse = new Pulse();

        
    
        public void AddInventory(List<Rice> riceList,List<Wheat> wheatList,List<Pulse> pulseList)
        {
            Console.WriteLine("Choose Inventory to Add Items:" +
                                "\n 1) Rice" +
                                "\n 2) Wheat" +
                                "\n 3) Pulses" +
                                "\n 4) Exit");



            Console.WriteLine("Enter choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Type of Rice");
                    rice.Name = Console.ReadLine();
                    Console.WriteLine("Enter Rice Price ");
                    rice.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Weight For Rice");
                    rice.Weight = Convert.ToInt32(Console.ReadLine());
                    riceList.Add(rice);
                    break;

                case 2:
                    Console.WriteLine("Enter Type of Wheat");
                    wheat.Name = Console.ReadLine();
                    Console.WriteLine("Enter Wheat Price ");
                    wheat.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Weight For Wheat");
                    wheat.Weight = Convert.ToInt32(Console.ReadLine());
                    wheatList.Add(wheat);
                    break;

                case 3:
                    Console.WriteLine("Enter Type of Pulse");
                    pulse.Name = Console.ReadLine();
                    Console.WriteLine("Enter Pulse Price ");
                    pulse.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Weight For Price");
                    pulse.Weight = Convert.ToInt32(Console.ReadLine());
                    pulseList.Add(pulse);
                    break;


                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }



        }


        public void DeleteRiceInventory(List<Rice> riceList)
        {

            Console.WriteLine("Enter name of Rice to be deleted");
            string name = Console.ReadLine();
            foreach (var item in riceList)
            {
                if (name == rice.Name)
                {
                    riceList.Remove(item);
                }
                else
                {
                    Console.WriteLine("Item is not Present");
                }
            }

        }

        public void DeleteWheatInventory(List<Wheat> wheatList)
        {

            Console.WriteLine("Enter name of wheat to be deleted");
            string name = Console.ReadLine();
            foreach (var item in wheatList)
            {
                if (name == wheat.Name)
                {
                    wheatList.Remove(item);
                }
                else
                {
                    Console.WriteLine("Item is not Present");
                }
            }

        }
        public void DeletePulsesInventory(List<Pulse> pulseList)
        {

            Console.WriteLine("Enter name of Pulse to be deleted");
            string name = Console.ReadLine();
            foreach (var item in pulseList)
            {
                if (name == pulse.Name)
                {
                    pulseList.Remove(item);
                }
                else
                {
                    Console.WriteLine("Item is not Present");
                }
            }

        }

        public void DisplayInventory(List<Rice> riceList, List<Wheat> wheatList, List<Pulse> pulseList)
        {
            Console.WriteLine("choose Display: " +
                                "1) Rice" +
                                "2) Wheat" +
                                "3) pulse");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach (Rice item in riceList)
                    {
                        Console.WriteLine("Name:{0} \nWeight:{1} \nPrice:{2}", item.Name, item.Weight, item.Price);
                    }
                    break;

                case 2:
                    foreach (Wheat item in wheatList)
                    {
                        Console.WriteLine("Name:{0} \nWeight:{1} \nPrice:{2}", item.Name, item.Weight, item.Price);
                    }
                    break;

                case 3:
                    foreach (Pulse item in pulseList)
                    {
                        Console.WriteLine("Name:{0} \nWeight:{1} \nPrice:{2}", item.Name, item.Weight, item.Price);
                    }
                    break;


            }





        }
    }

}

