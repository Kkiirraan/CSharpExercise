using System;
using System.Text.RegularExpressions;


namespace Name{
    public class Name{
        public static void Main(string[] args){
           Console.WriteLine("Enter a string : ");
           string str=Console.ReadLine();
           if(str.Length<4){
            Console.WriteLine(str.ToUpper());
           }else{
              string newStr="";
              newStr=str.Substring(0,4).ToUpper()+str.Substring(4).ToLower();
             Console.WriteLine(newStr);
           }

        }
    }
}
