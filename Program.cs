namespace InventoryManagement
{
    class Program

    {
        public static void Main(string[] args )
        {
            string path = "E:\\Bridgelabz_C_Sharp\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);

            for (int i = 0; i<data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].prize);

            }



        }

    }
}
