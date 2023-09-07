using ProductPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUtility
{
    internal class Utility<T> where T : ProductIF
    {
        string sortName;
        public Utility() 
        {
            this.sortName = "bubblesort";
        }
        public Utility(string sortName)
        {
            this.sortName = sortName.ToLower();
        }

        public string GetName()
        {
            return sortName;
        }

        public void SetName(string newName)
        {
            this.sortName = newName;
        }

        public virtual List<T> Sort<T>(List<T> data) where T : IComparable<T>
        {
            // Bubble sort with CompareTo
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - i - 1; j++)
                {
                    if (data[j].CompareTo(data[j + 1]) > 0) // Use CompareTo
                    {
                        T temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

            return data;
        }

    }
}
