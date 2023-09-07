﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPackage
{
    internal abstract class Product : ProductIF
    {
        int id;
        string name;
        double price;

        public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(int newPrice)
        {
            this.price = newPrice;
        }
    }
}