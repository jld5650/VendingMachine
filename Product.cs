using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    [Serializable]
    public class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public string id { get; set; }
        public string img { get; set; }
        public int inventory { get; set; }


    }
}
