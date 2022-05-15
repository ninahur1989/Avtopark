using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class Car : Vehicle
    {
        public override int MaxSpeed { get => 0; }
        public override int Price { get => 0; }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can drive  ");
        }
    }
}
