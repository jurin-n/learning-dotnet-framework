using System;

namespace Sample1
{
    class Sample1
    {
        static string program_ver = "sample #1";
        static void Main() { 
            Console.WriteLine(program_ver);
            Console.Write("お名前は？＞＞");
            string name = System.Console.ReadLine();
            Console.WriteLine($"ようこそ、{name}さん！");
        }
    }
}
