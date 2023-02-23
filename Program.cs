namespace InventoryManagement
{
    class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory Management Program Stock Problem!!");

            string path = "E:\\Bridgelabz_C_Sharp\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);


            for (int i = 0; i < data.typesofstock.Count; i++)
            {
                Console.WriteLine("StockName - "+data.typesofstock[i].stockname);
                Console.WriteLine("shareprice -"+data.typesofstock[i].shareprice);
                Console.WriteLine("numberofshare -"+data.typesofstock[i].numberofshare);
                int total = data.typesofstock[i].numberofshare * data.typesofstock[i].shareprice;
                Console.WriteLine("Total Stock Price : " + total);
                Console.WriteLine("********************************************");
            }

            for (int i = 0; i < data.typesofstock.Count; i++)
            {

                Console.WriteLine("Which stock You Want to Buy");
                String buy = Console.ReadLine();
                Console.WriteLine("How Many Stock You want to buy");
                int num = Convert.ToInt32(Console.ReadLine());
                if (buy == "Tata")
                {
                    Console.WriteLine("Buy Stock of : " + "Tata");
                    Console.WriteLine("Number of Stock Buy : " + num);
                    Console.WriteLine("Number of Remaining Stock : {0}", data.typesofstock[i].numberofshare - num);
                    Console.WriteLine("Total Price : " + num * 50);
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Number of Stock You Have : " + num);
                    Console.WriteLine("How Many Stock Want To sell");
                    int sell = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You Sell {0} Stock Remaining {1} Stock", sell, num - sell);
                    Console.WriteLine("Sell Stock Price : " + sell * 50);
                    break;
                }
                else if (buy == "Ratnamani")
                {
                    Console.WriteLine("Buy Stock of : " + "Ratnamani");
                    Console.WriteLine("Number of Stock Buy : " + num);
                    Console.WriteLine("Number of Remaining Stock : {0}", data.typesofstock[i].numberofshare - num);
                    Console.WriteLine("Total Price : " + num * 50);
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Number of Stock You Have : " + num);
                    Console.WriteLine("How Many Stock Want To sell");
                    int sell = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You Sell {0} Stock Remaining {1} Stock", sell, num - sell);
                    Console.WriteLine("Sell Stock Price : " + sell * 50);
                    break;
                }
                else if (buy == "MahindraTech")
                {
                    Console.WriteLine("Buy Stock of : " + "MahindraTech");
                    Console.WriteLine("Number of Stock Buy : " + num);
                    Console.WriteLine("Number of Remaining Stock : {0}", data.typesofstock[i].numberofshare - num);
                    Console.WriteLine("Total Price : " + num * 50);
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Number of Stock You Have : " + num);
                    Console.WriteLine("How Many Stock Want To sell");
                    int sell = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You Sell {0} Stock Remaining {1} Stock", sell, num - sell);
                    Console.WriteLine("Sell Stock Price : " + sell * 50);
                    break;
                }

            }
        }
           

    }
}


