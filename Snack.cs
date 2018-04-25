using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    [Serializable]
    public class Snack : Product
    {
        public string type { get; set; }
        public string flavor { get; set; }
    }
}
