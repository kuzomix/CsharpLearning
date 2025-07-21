using System;
using System.Runtime.ConstrainedExecution;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //模擬擲骰子，每次執行結果通常會不同
            Random random = new Random(); //產生隨機數字
                                          //Random類別再沒有指定種子情況下，會使用系統時間(毫秒)作為種子，所以每次執行程式產生的亂數序列都會不同

            //產生介於1~6之間的整數(不含7)，三行分別產生三個獨立的骰子點數
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble(); //產生介於0.0~1.0之間的浮點數不含1.0)

            //如果想讓每次執行結果都一樣
            //Random random = new Random(123); //固定種子

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();

        }
    }
}
