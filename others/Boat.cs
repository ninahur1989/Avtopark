using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    internal class Boat : Vehicle
    {
        private Random _random = new Random();
        public override int MaxSpeed { get => _random.Next(100, 300); }
        public override int Price { get => _random.Next(4000, 30000); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can swim \n ");
        }
    }
}
