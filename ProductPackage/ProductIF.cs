using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    public interface ProductIF : IComparable<ProductIF>
    {
        double GetPrice();
        //int CompareTo(ProductIF other);

    }
}
