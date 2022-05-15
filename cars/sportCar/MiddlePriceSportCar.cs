using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class MiddlePriceSportCar : SportCar
    {
        private Random _random = new Random();
        public override int MaxSpeed { get => 657; }
        public override int Price { get => _random.Next(50000, 300000); }
    }
}
