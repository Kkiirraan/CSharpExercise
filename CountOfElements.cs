using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           List<string> str=new List<string>(){"abc","Apple","mango"};
           Console.WriteLine("Enter a char : ");
           char ch=(char)Console.Read();
           int count=0;
           foreach(string word in str){
            if(char.ToLower(word[0])==char.ToLower(ch)){
                count+=1;
            }
           }
           Console.WriteLine(count);

        }
    }
}
