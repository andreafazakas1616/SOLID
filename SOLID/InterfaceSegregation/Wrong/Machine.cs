using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Wrong
{
    public interface IMachine
    {
        void Print(List<Item> item);
        void Staple(List<Item> item);
        void Fax(List<Item> item);
        void Scan(List<Item> item);
        void PhotoCopy(List<Item> item);
    }

    public class Machine : IMachine
    {
        public void Print(List<Item> item)
        {
            // Print the items.
            Console.WriteLine("All Items printed" + item.Count());
        }

        public void Staple(List<Item> item)
        {
            // Staple the items.
            Console.WriteLine("Items stapled" + item.Count());
        }

        public void Fax(List<Item> item)
        {
            // Fax the items.
            Console.WriteLine("All Items Faxed" + item.Count());
        }

        public void Scan(List<Item> item)
        {
            // Scan the items.
            Console.WriteLine("All Items Scanned" + item.Count());
        }

        public void PhotoCopy(List<Item> item)
        {
            // Xerox the items.
            Console.WriteLine("All Items Photo copied" + item.Count());
        }
    }

    public class Printer : IMachine
    {
        public void Fax(List<Item> item)
        {
            throw new NotImplementedException();
        }

        public void PhotoCopy(List<Item> item)
        {
            throw new NotImplementedException();
        }

        public void Print(List<Item> item)
        {
            Console.WriteLine("All Items printed" + item.Count());
        }

        public void Scan(List<Item> item)
        {
            throw new NotImplementedException();
        }

        public void Staple(List<Item> item)
        {
            throw new NotImplementedException();
        }
    }
}
