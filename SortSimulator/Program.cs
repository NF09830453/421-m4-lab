using ProductPackage;
using CompanyUtility;
using System.Net.Http.Headers;

namespace SortSimulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Desk d1 = new Desk(1, "office desk", 20.30);
            Desk d2 = new Desk(2, "wooden desk", 15.25);
            Desk d3 = new Desk(3, "glass desk", 25.13);
            Desk d4 = new Desk(4, "small desk", 5.85);

            List<ProductIF> desks = new List<ProductIF>();
            desks.Add(d1);
            desks.Add(d2);
            desks.Add(d3);
            desks.Add(d4);

            foreach (Desk desk in desks)
            {
                Console.WriteLine(desk.GetName());
            }
            XYZ xyz = new XYZ();
            xyz.utility = new Utility<ProductIF>();
            List<ProductIF> sortedDesks = xyz.utility.Sort(desks);

            Console.WriteLine("\nAfter sorting:");
            foreach (Desk desk in sortedDesks)
            {
                Console.WriteLine(desk.GetName() + ": " + desk.GetPrice());
            }
            


            Console.Read(); // prevents Console from closing immediately
        }
    }
}