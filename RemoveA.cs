using System;
namespace ProgramNamespace
{
    class Program
    {
        public static string RemoveA(string str)
        {
            string newStr="";
            foreach(char ch in str)
            {
                if(ch!='a' && ch!='A')
                {
                    // Console.WriteLine("ss");
                    newStr+=ch;
                }
            }
            return newStr;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            string result=RemoveA(str);
            Console.WriteLine(result);
        }
    }
}
