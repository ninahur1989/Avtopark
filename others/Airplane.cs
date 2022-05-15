using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class Airplane : Vehicle
    {
        private Random _random = new Random();
        public override int MaxSpeed { get => _random.Next(900, 1000); }
        public override int Price { get => _random.Next(25000, 100000); }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can fly \n");
        }
    }
}
