using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babylonSquareRoot
{
    class BabylonSquareRoot
    {
        static void Main(string[] args)
        {
            double num = 49;
            Console.WriteLine("Square root of " + num + " = " + (new BabylonSquareRoot()). BabylonianSquareRoot(num, .0001));
        }
        public double BabylonianSquareRoot(double a, double error)
        {
            double sqrt = a;
            while (Math.Abs(sqrt - a/sqrt) > error) {
                sqrt = (sqrt + a / sqrt) / 2;
            }
            return sqrt;
        }
    }
}
