using System;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initialization

            int y = 321;//declaration + initialization

            int z = x + y;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            int age = 21; //whole integer
            double height = 300.5; //decimal number
            bool alive = false; //true or false
            char symbol = '@';
            String name = "Bro";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();

        }
    }
}
