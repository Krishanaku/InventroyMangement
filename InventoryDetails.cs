using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryDetails
    {
        public List<TypesOfStock> typesofstock;

    }
    public class TypesOfStock
    {
        public int numberofshare;
        public int shareprice;
        public string? stockname;
    }
}

