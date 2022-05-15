using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    internal class FamilyCar : Car
    {
        private Random _random = new Random();
        public override int MaxSpeed { get => 60; }
        public override int Price { get => _random.Next(3000, 8000); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" SO slow \n");
        }
    }
}
