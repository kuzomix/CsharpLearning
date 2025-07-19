using System;
using System.Threading.Tasks.Dataflow;

namespace type_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a); //此方法可將a值從浮點數四捨五入轉換成整數

            int c = 123;
            double d = Convert.ToDouble(c); //此方法將整數c轉換成double浮點數
            //double d = Convert.ToDouble(c) + 0.1; //會得到123.1

            int e = 321;
            String f = Convert.ToString(e); //此方法將整數 e 轉換成字串

            String g = "$";
            char h = Convert.ToChar(g); //此方法將字串 g 轉換成字元，前提是字串只能有一個字元，否則會拋出錯誤

            String i = "true";
            bool j = Convert.ToBoolean(i); //此方法將字串"true"轉換成布林值

            Console.WriteLine(b);

            Console.WriteLine(a.GetType()); //印出變數a的資料型別
            Console.WriteLine(b.GetType());
            Console.WriteLine(d); //d值變成123.0，雖然是double型別，但如果小數點後是.0，Console只會顯示整數部分
            Console.WriteLine(d.GetType());
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
            Console.WriteLine(j); //已是布林值的true，不是字串的true
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}