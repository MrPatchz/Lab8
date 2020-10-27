using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza bigDaddy = new Pizza("small", 2, 2, 2);
            Console.Out.WriteLine("~~~~~~~~~~~~Initialize Pizza~~~~~~~~~~~~~~~~~");
            Console.Out.WriteLine(bigDaddy.ToString());
            Console.Out.WriteLine("~~~~~~~~~~~~Getters and setters~~~~~~~~~~~~~~~~~");
            bigDaddy.setSize("large");
            bigDaddy.setToppingCheese(10);
            bigDaddy.setToppingPep(10);
            bigDaddy.setToppingHam(10);
            Console.Out.WriteLine(bigDaddy.getSize());
            Console.Out.WriteLine(bigDaddy.getToppingCheese());
            Console.Out.WriteLine(bigDaddy.getToppingPep());
            Console.Out.WriteLine(bigDaddy.getToppingHam());
            Console.Out.WriteLine("~~~~~~~~~~~~Final ToString~~~~~~~~~~~~~~~~~");
            Console.Out.WriteLine(bigDaddy.ToString());
        }
    }
}
