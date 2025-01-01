using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            
            Console.WriteLine("Enter a string : ");
            string str=Console.ReadLine();
            string pattern=@"\b(is)\b";
            string result=Regex.Replace(str,pattern,"is not");

            Console.WriteLine(result);
         
        }
    }
}
