using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    interface IComparable<T>
    {
        double CompareTo(T other);
    }
}
