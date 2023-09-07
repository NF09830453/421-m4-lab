using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    public class Desk : Product, ProductIF
    {
        public Desk(int id, string name, double price) : base(id, name, price) { }
    }
}
