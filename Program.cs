namespace InventoryManagement
{
    class Program

    {
        public static void Main(string[] args )
        {
            string path = "E:\\Bridgelabz_C_Sharp\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);
            Console.WriteLine("Type of Rice");
            Console.WriteLine("*********************************************");

            for (int i = 0; i<data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].prize);

                Console.WriteLine("************************************************");

            }


            Console.WriteLine("Type of Pulses");
            Console.WriteLine("*********************************************");

            for (int i = 0; i < data.typeofPulses.Count; i++)
            {
                Console.WriteLine(data.typeofPulses[i].name);
                Console.WriteLine(data.typeofPulses[i].weight);
                Console.WriteLine(data.typeofPulses[i].prize);

                Console.WriteLine("************************************************");

            }

            Console.WriteLine("Type of Wheat");
            Console.WriteLine("*********************************************");

            for (int i = 0; i < data.typeofWheat.Count; i++)
            {
                Console.WriteLine(data.typeofWheat[i].name);
                Console.WriteLine(data.typeofWheat[i].weight);
                Console.WriteLine(data.typeofWheat[i].prize);

                Console.WriteLine("************************************************");

            }



        }

    }
}
