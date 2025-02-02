using System;
namespace ProgramNamespace
{
    class Program
    {
        public static int CountA(string str)
        {
            string[] newStr=str.Split(" ");
            if (newStr.Length<2) return 0;
            str=newStr[1];
            int count=0;
            foreach(char ch in str)
            {
                if(ch=='a' || ch=='A')
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            int result=CountA(str);
            Console.WriteLine(result);
        }
    }
}
