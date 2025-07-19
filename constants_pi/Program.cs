using System;

namespace constants_pi
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants = immutable value which are known at compile time
            //            and do not change for the life of the program

            //double pi = 3.14159; //一般變數的宣告，可以之後再修改pi的值
            const double pi = 3.14159; // 常數宣告，表示變數值是固定不變的，設定後不能再修改

            //pi = 420;

            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
