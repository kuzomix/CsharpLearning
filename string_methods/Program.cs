using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //兩個字串變數宣告
            String fullName = "Bro Code";
            String phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper(); //將fullName內容轉換成全大寫
            //fullName = fullName.ToLower(); //將fullName內容轉換成全小寫
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", ""); //使用Replace方法將phoneNumber中所有"-"字元移除
            Console.WriteLine(phoneNumber);

            String userName = fullName.Insert(0,"Mr."); //使用Insert方法將fullName開頭(索引0)插入"Mr."
            Console.WriteLine(userName);

            Console.WriteLine(fullName.Length); //輸出fullName長度(字元數)，包含空格

            String firstName = fullName.Substring(0, 3); //使用Substring方法擷取從索引0開始的3個字元
            String lastName = fullName.Substring(4, 4); //擷取從索引4開始的4個字元(跳過空格)

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();

        }
    }
}
