using System;
using System.Net.Security;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
            Console.WriteLine("Enter a string : ");
            string str=Console.ReadLine();
            char[] revArray=str.ToCharArray();
            Array.Reverse(revArray);
            string newStr=new string(revArray);
            if(str.ToLower()==newStr.ToLower()){
                Console.WriteLine("Palindrome");
            }else{
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
