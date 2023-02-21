using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryDetails
    {
        public List<TypeofRice> typeofRice;
    }
    public class TypeofRice
    {
        public string name;
        public int weight;
        public int prize;
    }
}
