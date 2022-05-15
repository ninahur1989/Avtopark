using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class HighPriceSportCar : SportCar
    {
        private Random _random = new Random();
        public override int MaxSpeed { get => 799; }
        public override int Price { get => _random.Next(300000, 700000); }
    }
}
