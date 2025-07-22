using System;

namespace hypotenuse_calculator_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A: "); //提示使用者輸入第一個直角邊
            double a = Convert.ToDouble(Console.ReadLine()); //讀取使用者輸入的字串並轉換成double儲存

            Console.WriteLine("Enter side B: "); //提示使用者輸入另一個直角邊
            double b = Convert.ToDouble(Console.ReadLine()); 

            double c = Math.Sqrt((a * a) + (b * b)); //畢氏定理c=根號a平方+b平方，Math.Sqrt計算平方根

            Console.WriteLine("The hypotenuse is: " + c); //得到斜邊長度

            Console.ReadKey();

        }
    }
}
