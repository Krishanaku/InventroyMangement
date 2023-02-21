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
        public List<TypeofPulses> typeofPulses;
        public List<Typeofwheat> typeofWheat;
    }
    public class TypeofRice
    {
        public string name;
        public int weight;
        public int prize;
    }
    public class TypeofPulses
    {
        public string name;
        public int weight;
        public int prize;
    }
    public class Typeofwheat
    {
        public string name;
        public int weight;
        public int prize;
    }
}
