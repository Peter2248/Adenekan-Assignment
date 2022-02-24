using System;
namespace solution
{
    class assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int x_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double y_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string z_str = Console.ReadLine();

            Console.WriteLine(i + x_int);
            Console.WriteLine(d + y_double);
            Console.WriteLine(s + z_str);

        }

    }
}



