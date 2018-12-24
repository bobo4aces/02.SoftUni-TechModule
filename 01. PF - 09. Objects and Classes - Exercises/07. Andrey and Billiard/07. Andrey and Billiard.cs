using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Clients
    {
        public string Name { set; get; }
        public Dictionary<string,int> ShopList { set; get; }
        public decimal Bill { set; get; }
        public Clients(string name,string product,int quantity)
        {
            Name = name;
            ShopList = new Dictionary<string, int>();
            if (ShopList.ContainsKey(product))
            {
                ShopList[product] += quantity;
            }
            else
            {
                ShopList.Add(product, quantity);
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,decimal> menuList= new Dictionary<string, decimal>();
            while (n-->0)
            {
                string[] menuInfo = Console.ReadLine().Split('-').ToArray();
                string product = menuInfo[0];
                decimal price = decimal.Parse(menuInfo[1]);
                if (!menuList.ContainsKey(product))
                {
                    menuList.Add(product, price);
                }
                else
                {
                    menuList[product] = price;
                }
            }

            List<string> clientsInfo = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();
            List<Clients> clientsList = new List<Clients>();
            while (clientsInfo[0] != "end of clients")
            {
                
                string client = clientsInfo[0];
                string product = clientsInfo[1];
                int quantity = int.Parse(clientsInfo[2]);
                Clients currentClient = new Clients(client, product, quantity);
                if (menuList.ContainsKey(product))
                {
                    bool isExistingClient = false;
                    for (int i = 0; i < clientsList.Count; i++)
                    {
                        if (clientsList[i].Name==currentClient.Name)
                        {
                            if (clientsList[i].ShopList.ContainsKey(product))
                            {
                                clientsList[i].ShopList[product] += quantity;
                            }
                            else
                            {
                                clientsList[i].ShopList.Add(product, quantity);
                            }
                            isExistingClient = true;
                            break;
                        }
                    }
                    if (!isExistingClient)
                    {
                        clientsList.Add(currentClient);
                    }

                }
                clientsInfo = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();
            }

            foreach (var client in clientsList)
            {
                foreach (var menu in menuList)
                {
                    if (client.ShopList.ContainsKey(menu.Key))
                    {
                        client.Bill += menu.Value * client.ShopList[menu.Key];
                    }
                }
            }
            decimal totalBill = 0;
            foreach (var client in clientsList.OrderBy(c => c.Name))
            {
                Console.WriteLine(client.Name);
                foreach (var product in client.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:f2}");
                totalBill += client.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
