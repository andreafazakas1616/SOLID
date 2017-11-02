using SOLID.InterfaceSegregation.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Right
{
    interface IPrinter
    {
        void Print(List<Item> Items);
    }

    class Printer : IPrinter
    {
        public void Print(List<Item> Items)
        {
            //print items
        }
    }

    interface IStaple
    {
        void Staple(List<Item> Items);
    }

    class Stapler : IStaple
    {
        public void Staple(List<Item> Items)
        {
            //staple items
        }

        //Other definitions...
    }

    interface IFax
    {
        void Fax(List<Item> Items);
    }

    class FaxMachine : IFax
    {
        public void Fax(List<Item> Items)
        {
            //fax things
        }

    }

    interface IScan
    {
        void Scan(List<Item> Items);
    }

    class Scanner : IScan
    {
        public void Scan(List<Item> Items)
        {
            //scan things
        }
    }

    interface IPhotoCopy
    {
        void PhotoCopy(List<Item> Items);
    }

    class PhotoCopyMachine : IPhotoCopy
    {
        public void PhotoCopy(List<Item> Items)
        {
            //photocopy
        }
    }
 }