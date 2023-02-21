namespace InventoryManagement
{
    class Program

    {
        public static void Main(string[] args )
        {
            string path = "E:\\Bridgelabz_C_Sharp\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);


            Console.WriteLine(data.typeofRice.name);
            Console.WriteLine(data.typeofRice.weight);
            Console.WriteLine(data.typeofRice.prize);


        }

    }
}
