using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    public class SportCar : Car
    {
        public SportCar()
        {
            WinterTire tire = new WinterTire();
            Tire = tire;
        }

        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" SO fast \n");
        }
    }
}
