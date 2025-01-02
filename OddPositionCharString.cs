using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           Console.WriteLine("Enter a string : ");
           string str=Console.ReadLine();
           if(str.Length<2){
            Console.WriteLine(str);
           }else{
              string newStr="";
              for(int i=0;i<str.Length;i+=2){
                newStr+=str[i];
              }
              Console.WriteLine(newStr);
           }

        }
    }
}
