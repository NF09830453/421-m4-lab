﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    public interface IComparable<T>
    {
        int CompareTo(T other);
    }
}
