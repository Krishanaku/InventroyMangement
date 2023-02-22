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
                Console.WriteLine(data.typesofstock[i].stockname);
                Console.WriteLine(data.typesofstock[i].shareprice);
                Console.WriteLine(data.typesofstock[i].numberofshare);
                int total = data.typesofstock[i].numberofshare * data.typesofstock[i].shareprice;
                Console.WriteLine("Total Stock Price : " + total);
                Console.WriteLine("********************************************");
            }
        }
           

    }
}


