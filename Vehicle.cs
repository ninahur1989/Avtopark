using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public abstract class Vehicle : IComparable, ICapacity
    {
        public abstract int MaxSpeed { get; }
        public abstract int Price { get; }
        public virtual void Opportunities()
        {
            Console.WriteLine("i'm not alive ");
        }

        public int CompareTo(object o)
        {
            Vehicle p = o as Vehicle;
            if (p != null)
            {
                return Price.CompareTo(p.Price);
            }
            else
            {
                throw new Exception("error");
            }
        }

        public void CapacityCheck(ICapacity capacity)
        {
            capacity.Capacity();
        }

        public void Capacity()
        {
            Console.WriteLine("i can include 1-200 people");
        }
    }
}
