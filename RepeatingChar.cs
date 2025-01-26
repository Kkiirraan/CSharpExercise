using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProgramNameSpace
{
    class Program 
    {
        public static bool CheckDup(string str)
        {
            bool[] charSet=new bool[26];
            foreach(char ch in str)
            {
                if(ch < 'a' || ch > 'z')continue;
                if(charSet[ch-'a']) return false;
                charSet[ch-'a']=true;
            }
            return true;
        }
        public static void Main(string[] args)
        {
         Console.WriteLine("Enter a string: ");
         string str=Console.ReadLine();
         bool ans=CheckDup(str);
         Console.WriteLine(ans);
        }
    }
}
