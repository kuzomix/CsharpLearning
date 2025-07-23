using System;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision making

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //讀取使用者輸入，轉換為整數型別 int，儲存到變數 age 中，根據輸入的數字範圍不同會顯示不同文字
            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if(age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }

            //讀取使用者輸入文字，儲存到變數 name 中
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your name!");
            }
            Console.ReadKey();

        }
    }
}