using System;
namespace ProgramNamespace
{
    class Program
    {
        public static int CountA(string str)
        {
            string[] newStr=str.Split(" ");
            if (newStr.Length<2) return 0;
            int count=0;
            for(int i=1;i<newStr.Length;i++)
            {
                foreach(char ch in newStr[i])
                {
                    if(ch=='a' || ch=='A')
                    {
                        count++;
                    }
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
