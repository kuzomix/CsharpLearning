using System;
using System.Runtime.ConstrainedExecution;

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?"); //主控台顯示文字
            String name = Console.ReadLine(); //等待使用者輸入名字，並把輸入的內容存到 name 這個字串變數中

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //等待使用者輸入年齡（字串形式），把它轉換成整數，存到 age 變數中

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

            Console.ReadKey();

        }
    }
}
