using System;
using System.Runtime.ConstrainedExecution;

namespace Math_class
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 3); //x的3次方
            //double b = Math.Sqrt(x); //x的平方根
            //double c = Math.Abs(x); //取絕對值x
            //double d = Math.Round(x); //四捨五入x(3.0->3)
            //double e = Math.Ceiling(x); //無條件進位(天花板函數)
            //double f = Math.Floor(x); //無條件捨去(地板函數)
            //double g = Math.Max(x, y); // 取兩數中較大的值
            //double h = Math.Min(x, y); // 取兩數中較小的值

            Console.WriteLine(a);

            Console.ReadKey();

        }
    }
}
