using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class Car : Vehicle, ITire, ICapacity
    {
        public ITire Tire { get; set; }
        public override int MaxSpeed { get => 0; }
        public override int Price { get => 0; }

        public new void Capacity()
        {
            Console.WriteLine("i can include 1-40 people");
        }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can drive  ");
        }
    }
}
