using System;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello!");

            //This is a comment
            /*
             * this
             * is
             * a
             * multiline
             * comment
             */

            //使用不同的跳脫字元
            Console.WriteLine("\tBroCode");// "\t"是Tab鍵，會在文字前插入一個水平縮排
            Console.WriteLine("Bro\bCode");// "\b"是Backspace退格，會刪除前一個字元
            Console.WriteLine("Bro\nCode");// "\n"是換行符號
            Console.ReadKey();//會讓程式暫停執行，直到使用者按下鍵盤任意鍵才會繼續往下執行
            
        }
    }
}
