using System;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           char[] chars;
           Console.WriteLine("Enter a string : ");
           chars=Console.ReadLine().ToCharArray();
           foreach(char ch in chars){
            if(char.IsWhiteSpace(ch)){
                break;
            }else{
            Console.Write(ch);
            }
           }
        }
    }
}
