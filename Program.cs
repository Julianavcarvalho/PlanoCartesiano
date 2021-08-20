using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            String[] pc = Console.ReadLine().Split(' ');
            double x = int.Parse(pc[0], CultureInfo.InvariantCulture);
            double y = int.Parse(pc[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Q1");
                    pc = Console.ReadLine().Split(' '); ;
                    x = int.Parse(pc[0], CultureInfo.InvariantCulture);
                    y = int.Parse(pc[1], CultureInfo.InvariantCulture);
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Q4");
                    pc = Console.ReadLine().Split(' '); ;
                    x = int.Parse(pc[0], CultureInfo.InvariantCulture);
                    y = int.Parse(pc[1], CultureInfo.InvariantCulture);
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Q3");
                    pc = Console.ReadLine().Split(' '); ;
                    x = int.Parse(pc[0], CultureInfo.InvariantCulture);
                    y = int.Parse(pc[1], CultureInfo.InvariantCulture);
                }
                else {
                    Console.WriteLine("Q2");
                    pc = Console.ReadLine().Split(' '); ;
                    x = int.Parse(pc[0], CultureInfo.InvariantCulture);
                    y = int.Parse(pc[1], CultureInfo.InvariantCulture);
                }
            }

        }
    }
}