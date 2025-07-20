using System;

namespace arithmetic_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            //double friends = 5;

            //讓friends增加的不同寫法
            //friends = friends + 2;
            //friends += 2; //簡寫
            //friends++; //每次增加1

            //讓friends減少的不同寫法
            //friends = friends - 1;
            //friends -= 1; //簡寫
            //friends--; //每次減1

            //讓friends 的值乘以 2
            //friends = friends * 2;
            //friends *= 2;

            //讓friends 的值除以 2，整數除法會去掉小數
            //friends = friends / 2;
            //friends /= 2;

            //%取餘數，remainder會儲存這個結果
            int remainder = friends % 2;

            //Console.WriteLine(friends);
            Console.WriteLine(remainder);

            Console.ReadKey();

        }
    }
}
