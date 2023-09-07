using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    internal class Desk<T> : Product
    {
        public Desk(int id, string name, double price) : base(id, name, price) { }
    }
}
